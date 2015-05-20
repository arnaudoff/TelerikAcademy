// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

function isDivisableBySevenAndFive(number) {
	return number % 35 === 0;
}

console.log(isDivisableBySevenAndFive(666));
console.log(isDivisableBySevenAndFive(70));