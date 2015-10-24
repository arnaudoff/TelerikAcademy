USE master
GO

CREATE DATABASE Accounts
GO

USE Accounts
GO

CREATE TABLE Persons (
	PersonID int IDENTITY NOT NULL PRIMARY KEY,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	SSN nvarchar(50)
)
GO

CREATE TABLE Accounts(
	AccountID int IDENTITY NOT NULL PRIMARY KEY,
	PersonId int NOT NULL FOREIGN KEY REFERENCES Persons(PersonID),
	Balance money
)
GO

INSERT INTO Persons (FirstName, LastName, SSN) VALUES ('Pesho', 'Peshev', '12345678'), ('Gosho', 'Goshev', '87654321')
GO

INSERT INTO Accounts (PersonID, Balance) VALUES (1, 548.14), (2, 2253.52)
GO

CREATE PROCEDURE usp_GetFullNames
	AS
		SELECT FirstName + ' ' + LastName AS FullName
		FROM Persons
GO

EXEC usp_GetFullNames

CREATE PROCEDURE usp_SelectAccountsWithBalanceGreaterThan(@minbalance money = 1000)
	AS
		SELECT p.FirstName, p.LastName, a.Balance
		FROM Persons p
		INNER JOIN Accounts a
			ON a.PersonId = p.PersonId
		WHERE a.Balance > @minbalance
GO

EXEC usp_SelectAccountsWithBalanceGreaterThan 2000

CREATE FUNCTION ufn_CalculateSumWithInterest (@sum MONEY, @yearInterest DECIMAL, @months INT) RETURNS MONEY
	AS
		BEGIN
			RETURN (@sum + @sum*(@yearInterest/100)*@months/12)
		END
GO

DECLARE @sum MONEY = (SELECT Balance FROM Accounts WHERE PersonId = 1)
PRINT dbo.ufn_CalculateSumWithInterest(@sum, 2, 5)

CREATE PROCEDURE dbo.usp_CalculateInterestPerMonth(@accountId int, @yearlyInterestRate decimal)
AS
	DECLARE @balance money
	SELECT @balance = Balance FROM Accounts WHERE AccountID = @accountId
	
	DECLARE @newBalance money
	SELECT @newBalance = dbo.ufn_CalculateSumWithInterest(@balance,@yearlyInterestRate,1)
	
	SELECT p.FirstName, p.LastName, a.Balance, @newBalance AS [New Balance]
	FROM Persons p
	INNER JOIN Accounts a
		ON p.PersonID = a.PersonId
	WHERE a.AccountID = @accountId
GO

EXEC dbo.usp_CalculateInterestPerMonth 1, 5.2

CREATE PROCEDURE dbo.usp_WithdrawMoney(@accountId int, @money money)
AS
    BEGIN TRAN
        UPDATE Accounts
        SET Balance -= @money
        WHERE AccountId = @accountId
    COMMIT TRAN
GO

CREATE PROCEDURE dbo.usp_DepositMoney(@accountId int, @money money)
AS
    BEGIN TRAN
        UPDATE Accounts
        SET Balance += @money
        WHERE AccountId = @accountId
    COMMIT TRAN
GO

EXEC dbo.usp_WithdrawMoney 1, 500

EXEC dbo.usp_DepositMoney 1, 500

CREATE TABLE Logs(
	LogID int IDENTITY NOT NULL PRIMARY KEY,
	AccountID int NOT NULL FOREIGN KEY REFERENCES Accounts(AccountID),
	OldSum money,
	NewSum money
)

CREATE TRIGGER tr_UpdateAccountBalance ON Accounts FOR UPDATE
AS
    DECLARE @oldSum money;
    SELECT @oldSum = Balance FROM deleted;

    INSERT INTO Logs(AccountId, OldSum, NewSum)
        SELECT AccountId, @oldSum, Balance
        FROM inserted
GO

EXEC usp_WithdrawMoney 1, 1000
EXEC usp_WithdrawMoney 1, 1000
EXEC usp_DepositMoney 2, 2000

SELECT * FROM Logs

USE TelerikAcademy
GO

CREATE FUNCTION ufn_SearchForPatternInNameOrTown(@pattern nvarchar(255))
	RETURNS @MatchedNames TABLE (Name varchar(50))
AS
BEGIN
	INSERT @MatchedNames
	SELECT * 
	FROM
		(SELECT e.FirstName FROM Employees e
        UNION
        SELECT e.LastName FROM Employees e
        UNION 
        SELECT t.Name FROM Towns t) as temp(name)
    WHERE PATINDEX('%[' + @pattern + ']', name) > 0
	RETURN
END
GO

SELECT * FROM ufn_SearchForPatternInNameOrTown('oistmiahf')
GO

DECLARE eCursor CURSOR READ_ONLY FOR
    SELECT e1.FirstName, e1.LastName, t1.Name, e2.FirstName, e2.LastName
    FROM Employees e1
    INNER JOIN Addresses a1
        ON e1.AddressID = a1.AddressID
    INNER JOIN Towns t1
        ON a1.TownID = t1.TownID,
        Employees e2
    INNER JOIN Addresses a2
        ON e2.AddressID = a2.AddressID
    INNER JOIN Towns t2
        ON a2.TownID = t2.TownID
    WHERE t1.TownID = t2.TownID AND e1.EmployeeID != e2.EmployeeID
    ORDER BY e1.FirstName, e2.FirstName

OPEN eCursor

DECLARE @firstName1 nvarchar(50), 
        @lastName1 nvarchar(50),
        @townName nvarchar(50),
        @firstName2 nvarchar(50),
        @lastName2 nvarchar(50)
FETCH NEXT FROM eCursor INTO @firstName1, @lastName1, @townName, @firstName2, @lastName2

DECLARE @counter int;
SET @counter = 0;

WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @counter = @counter + 1;

		PRINT @firstName1 + ' ' + @lastName1 + 
			  '     ' + @townName + '       ' +
			  @firstName2 + ' ' + @lastName2;

		FETCH NEXT FROM eCursor 
		INTO @firstName1, @lastName1, @townName, @firstName2, @lastName2
	END

print 'Total records: ' + CAST(@counter AS nvarchar(10));

CLOSE eCursor
DEALLOCATE eCursor