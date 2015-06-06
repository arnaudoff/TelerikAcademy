// Write a function that returns the last digit of given integer as an English word.

function getLastDigitAsWord(number) {
	var digit = number % 10;

	switch (digit) {
		case 0:
			return 'zero';
		case 1:
			return 'one';
		case 2:
			return 'two';
		case 3:
			return 'three';
		case 4:
			return 'four';
		case 5:
			return 'five';
		case 6:
			return 'six';
		case 7:
			return 'seven';
		case 8:
			return 'eight';
		case 9:
			return 'nine';
	}
}

console.log(getLastDigitAsWord(512));
console.log(getLastDigitAsWord(1024));
console.log(getLastDigitAsWord(12309));