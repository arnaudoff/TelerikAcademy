// Write an expression that checks for given integer if its third digit (right-to-left) is 7.

function isThirdDigitSeven(number) {
	return ((number / 100) | 0) % 10 === 7;
}

console.log(isThirdDigitSeven(9999799));
console.log(isThirdDigitSeven(5));