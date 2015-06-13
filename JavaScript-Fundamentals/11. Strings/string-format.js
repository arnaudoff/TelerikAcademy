/*
	Write a function that formats a string using placeholders.
	The function should work with up to 30 placeholders and all types.
*/

function stringFormat() {
	// Using 'arguments' in the callback of replace() thinking it's stringFormat's arguments and debugging afterwards might cause depression, anger, hate and similar intense emotions.		
	var formatArgs = arguments;

	return formatArgs[0].replace(/{(\d+)}/g, function (match, placeholderIndex) {
		return formatArgs[++placeholderIndex];
	});
}

var str = stringFormat('Hello {0}!', 'Peter');
console.log(str);

var frmt = '{0}, {1}, {0} text {2}';
var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
console.log(str);