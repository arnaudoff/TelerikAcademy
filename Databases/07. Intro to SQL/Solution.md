1. What is SQL? What is DML? What is DDL? Recite the most important SQL commands.

  **Structured Query Language** (SQL) is a special-purpose programming language designed for managing data held in a relational database management system (RDBMS), or for stream processing in a relational data stream management system (RDSMS). 
  
  **Data Manipulation Language** (DML) is the subset of SQL used to add, update and delete data: INSERT, UPDATE, DELETE and MERGE
  
  **Data Definition Language** (DDL) manages table and index structure. The most basic items of DDL are the CREATE, ALTER, RENAME, DROP and TRUNCATE statements.

2. What is Transact-SQL (T-SQL)?

  **Transact-SQL** (T-SQL) is Microsoft's and Sybase's proprietary extension to SQL. T-SQL expands on the SQL standard to include procedural programming, local variables, various support functions for string processing, date processing, mathematics, etc. and changes to the DELETE and UPDATE statements. 
  These additional features make Transact-SQL Turing complete. Transact-SQL is central to using Microsoft SQL Server. All applications that communicate with an instance of SQL Server do so by sending Transact-SQL statements to the server, regardless of the user interface of the application.

3. Start SQL Management Studio and connect to the database TelerikAcademy. Examine the major tables in the "TelerikAcademy" database.
4. Write a SQL query to find all information about all departments (use "TelerikAcademy" database).

  ```sql
  SELECT *
  FROM TelerikAcademy.dbo.Departments
  ```
  
5. Write a SQL query to find all department names.

  ```sql
  SELECT Name as DepartmentName
  FROM TelerikAcademy.dbo.Departments
  ```

6. Write a SQL query to find the salary of each employee.

  ```sql
  SELECT Salary
  FROM TelerikAcademy.dbo.Employees
  ```

7. Write a SQL to find the full name of each employee.

  ```sql
  SELECT FirstName + ' ' + LastName as FullName
  FROM TelerikAcademy.dbo.Employees
  ```

8. Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".
  
  ```sql
  SELECT FirstName + '.' + LastName + '@telerik.com' as FullEmailAddresses
  FROM TelerikAcademy.dbo.Employees
  ```

9. Write a SQL query to find all different employee salaries.

  ```sql
  SELECT DISTINCT Salary
  FROM TelerikAcademy.dbo.Employees
  ```

10. Write a SQL query to find all information about the employees whose job title is “Sales Representative“.

  ```sql
  SELECT *
  FROM TelerikAcademy.dbo.Employees
  WHERE JobTitle = 'Sales Representative'
  ```

11. Write a SQL query to find the names of all employees whose first name starts with "SA".

  ```sql
  SELECT FirstName
  FROM TelerikAcademy.dbo.Employees
  WHERE FirstName LIKE 'SA%'
  ```

12. Write a SQL query to find the names of all employees whose last name contains "ei".

  ```sql
  SELECT LastName
  FROM TelerikAcademy.dbo.Employees
  WHERE LastName LIKE '%ei%'
  ```

13. Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].

  ```sql
  SELECT Salary
  FROM TelerikAcademy.dbo.Employees
  WHERE Salary BETWEEN 20000 AND 30000
  ```

14. Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

  ```sql
  SELECT FirstName + ' ' + LastName as FullName, Salary
  FROM TelerikAcademy.dbo.Employees
  WHERE Salary IN (25000, 14000, 12500, 23600)
  ```
  
15. Write a SQL query to find all employees that do not have manager.

  ```sql
  SELECT * 
  FROM TelerikAcademy.dbo.Employees
  WHERE ManagerID IS NULL
  ```
  
16. Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.

  ```sql
  SELECT * 
  FROM TelerikAcademy.dbo.Employees
  WHERE Salary > 50000
  ORDER BY Salary DESC
  ```
  
17. Write a SQL query to find the top 5 best paid employees.

  ```sql
  SELECT TOP 5 * 
  FROM TelerikAcademy.dbo.Employees
  ORDER BY Salary DESC
  ```
  
18. Write a SQL query to find all employees along with their address. Use inner join with ON clause.

  ```sql
  SELECT * 
  FROM TelerikAcademy.dbo.Employees e
  INNER JOIN TelerikAcademy.dbo.Addresses a
    ON (e.AddressID = a.AddressID)
  ```
  
19. Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).

  ```sql
  SELECT * 
  FROM TelerikAcademy.dbo.Employees e, TelerikAcademy.dbo.Addresses a
  WHERE (e.AddressID = a.AddressID)
  ```
  
20. Write a SQL query to find all employees along with their manager.

  ```sql
  SELECT e.FirstName + ' ' + e.LastName as EmployeeName, m.FirstName + ' ' + m.LastName as ManagerName
  FROM TelerikAcademy.dbo.Employees e
  INNER JOIN TelerikAcademy.dbo.Employees m
    ON (e.ManagerID = m.EmployeeID)
  ```
  
21. Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.

  ```sql
  SELECT e.FirstName + ' ' + e.LastName AS EmployeeName, m.FirstName + ' ' + m.LastName AS ManagerName, a.AddressText AS EmployeeAddress
  FROM TelerikAcademy.dbo.Employees e
  INNER JOIN TelerikAcademy.dbo.Employees m
    ON (e.ManagerID = m.EmployeeID)
  INNER JOIN TelerikAcademy.dbo.Addresses a
    ON (m.AddressID = a.AddressID)
  ```
  
22. Write a SQL query to find all departments and all town names as a single list. Use UNION.

  ```sql
  SELECT Name FROM TelerikAcademy.dbo.Departments
  UNION
  SELECT Name FROM TelerikAcademy.dbo.Towns
  ```
  
23. Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.

  ```sql
  SELECT e.FirstName + ' ' + e.LastName AS EmployeeName, m.FirstName + ' ' + m.LastName AS ManagerName
  FROM TelerikAcademy.dbo.Employees e
  RIGHT OUTER JOIN TelerikAcademy.dbo.Employees m
    ON (e.ManagerID = m.EmployeeID)
  ```
  
24. Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.

  ```sql
  SELECT e.FirstName + ' ' + e.LastName AS FullName, YEAR(e.HireDate) AS Year, d.Name AS DepartmentName
  FROM TelerikAcademy.dbo.Employees e
  INNER JOIN TelerikAcademy.dbo.Departments d
    ON (e.DepartmentID = d.DepartmentID)
  WHERE (d.Name IN ('Sales', 'Finance')) AND (YEAR(e.HireDate) BETWEEN 1995 AND 2005)
  
  ```
  
