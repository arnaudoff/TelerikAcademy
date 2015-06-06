// Write a function that reverses the digits of given decimal number.

function reverseNumber(number) {
	var arrNumber = number.toString().split('');
	return arrNumber.reverse().join('');
}

console.log(reverseNumber(256));
console.log(reverseNumber(123.45));