// Write a JavaScript function that reverses a string and returns it.

function reverse(str) {
	var i,
		len = str.length,
		result = '';

	for (i = str.length - 1; i >= 0; i -= 1) {
		result += str[i];
	}

	return result;
}

console.log(reverse('sample'));