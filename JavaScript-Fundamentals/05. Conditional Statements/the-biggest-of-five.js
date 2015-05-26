/*
	Write a script that finds the greatest of given 5 variables.
	Use nested if statements.
*/

// Not crazy enough to use nested ifs after suffering the fourth task.

var numbers = [
	[5, 2, 2, 4, 1],
	[-2, -22, 1, 0, 0],
	[-2, 4, 3, 2, 0],
	[0, -2.5, 0, 5, 5],
	[-3, -0.5, -1.1, -2, -0.1]
];

for (var i = 0; i < numbers.length; i += 1) {
	var greatest = numbers[i][0];

	for (var j = 1; j < numbers[i].length; j += 1) {
		if (numbers[i][j] > greatest) {
			greatest = numbers[i][j];
		}
	}

	console.log(greatest);
}