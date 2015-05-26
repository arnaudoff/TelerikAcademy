/*
	Sort 3 real values in descending order.
	Use nested if statements.
	
	Note: Don’t use arrays and the built-in sorting functionality.
*/

function sort(a, b, c) {
	if (a >= b) {
		if (a >= c) {
			if (b >= c) {
				sorted = a + ' ' + b + ' ' + c;
			} else {
				sorted = a + ' ' + c + ' ' + b;
			}
		} else {
			if (b >= a) {
				sorted = c + ' ' + b + ' ' + a;
			} else {
				sorted = c + ' ' + a + ' ' + b;
			}
		}
	} else {
		if (b >= c) {
			if (a >= c) {
				sorted = b + ' ' + a + ' ' + c;
			} else {
				sorted = b + ' ' + c + ' ' + a;
			}
		} else {
			sorted = c + ' ' + b + ' ' + a;
		}
	}

	return sorted;
}

console.log(sort(5, 1, 2));
console.log(sort(-2, -2, 1));
console.log(sort(-2, 4, 3));
console.log(sort(0, -2.5, 5));
console.log(sort(-1.1, -0.5, -0.1));
console.log(sort(10, 20, 30));
console.log(sort(1, 1, 1));