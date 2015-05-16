// Write an expression that checks if given integer is odd or even.

function isEven(number) {
	return number % 2 === 0;
}

// console.log(isEven(1337));

// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

function isDivisableBySevenAndFive(number) {
	return number % 35 === 0;
}

// console.log(isDivisableBySevenAndFive(666));

// Write an expression that calculates rectangle’s area by given width and height.

function calculateRectangularArea(width, height) {
	return width * height;
}

// console.log(calculateRectangularArea(5, 5));

// Write an expression that checks for given integer if its third digit (right-to-left) is 7.

function isThirdDigitSeven(number) {
	return ((number / 100) | 0) % 10 == 7;
}

// console.log(isThirdDigitSeven(9999799));

/* 
	Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
	The bits are counted from right to left, starting from bit #0.
	The result of the expression should be either 1 or 0.
*/

function getThirdBit(number) {
	return (number & (1 << 3)) >> 3;
}

// console.log(getThirdBit(62241));

function isPointInCircle(x, y) {
	if () {
		
	}
}
