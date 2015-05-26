function printNotDivisibleNumbers(n) {
	for (var i = 1; i <= n; i += 1) {
		if (i % 21) { // 3 and 7 are relatively prime integers.
			console.log(i);
		}
	}
}

printNotDivisibleNumbers(22);