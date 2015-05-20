// Write an expression that checks if given positive integer number n (n ≤ 100) is prime.

function isPrime(number) {
    if (number < 2) { 
    	return false;
    }

    for (var divisor = 2; divisor <= Math.sqrt(number); divisor++) {
        if (number % divisor === 0) {
        	return false;
        }
    }

    return true;
}

console.log(isPrime(13));
console.log(isPrime(24));