/*
	Write a function that finds all the occurrences of word in a text.
	The search can be case sensitive or case insensitive.
	Use function overloading.
*/

var text = "The name of gosho is actually GOSHO.";

function countOccurrences(text, word, isCaseSensitive) {
	var regexStr = '\\b' + word + '\\b', // Note: \b is used to match a whole word
		flags = isCaseSensitive ? 'g' : 'gi', // g stands for global (to search throughout the text); i stands for ignore case
		regex = new RegExp(regexStr, flags);
		
	return text.match(regex).length;
}

console.log(countOccurrences(text, 'gosho', true));
console.log(countOccurrences(text, 'gosho', false));