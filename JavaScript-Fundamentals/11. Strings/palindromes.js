// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

var text = "ABBA is the best band, ever. God knows what a lamal is. Window's executables have an exe extension.";

function checkPalindrome(str) {
	if (str.length < 2) {
		return false;
	}

	var tmp = str.split('').reverse();
	return tmp.join('') === str;
}

function extractPalindromes(text) {
	var result = [];

	text.split(' ').forEach(function (word) {
		if (checkPalindrome(word)) {
			result.push(word);
		}
	});

	return result;
}

console.log(extractPalindromes(text));