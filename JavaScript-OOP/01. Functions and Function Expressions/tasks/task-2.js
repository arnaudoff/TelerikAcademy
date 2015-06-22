/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(from, to) {
	if (typeof from === 'undefined'|| typeof to === 'undefined') {
		throw Error;
	}
	var i,
		result = [],
		isCurrentPrime;

	for (i = from; i <= to; i++) {
		if ((i <= 1) || ((i > 2) && (i % 2 === 0))) {
			continue;
		} else {
			isCurrentPrime = true;

			for (j = 2; j < Math.sqrt(i); j++) {
				if (i % j === 0) {
					isCurrentPrime = false;
				}
			}

			if (isCurrentPrime) {
				result.push(i);
			}
		}
	}

	return result;
}

console.log(findPrimes(0, 5));
module.exports = findPrimes;
