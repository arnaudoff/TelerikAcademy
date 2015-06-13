// Write a JavaScript function to check if in a given expression the brackets are put correctly.

function checkBrackets(expression) {
	var leftCount = 0,
		rightCount = 0,
		i;

	for (i = 0, len = expression.length; i < len; i += 1) {
		if (expression[i] === '(') {
			leftCount++;
		}

		if (expression[i] === ')') {
			rightCount++;
		}
	}

	return leftCount === rightCount;
}

console.log(checkBrackets('((a+b)/5-d)'));
console.log(checkBrackets(')(a+b))'));