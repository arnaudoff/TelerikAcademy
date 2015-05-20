/* 
	Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
	The bits are counted from right to left, starting from bit #0.
	The result of the expression should be either 1 or 0.
*/

function getThirdBit(number) {
	return (number & (1 << 3)) >> 3;
}

console.log(getThirdBit(62241));