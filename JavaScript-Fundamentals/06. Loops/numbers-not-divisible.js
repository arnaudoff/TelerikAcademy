// Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

function printNotDivisibleNumbers(n) {
	for (var i = 1; i <= n; i += 1) {
		if (i % 21) { // 3 and 7 are relatively prime integers.
			console.log(i);
		}
	}
}

printNotDivisibleNumbers(22);