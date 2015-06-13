// Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

var text = "We are livINg in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

function countOccurrences(text, substr, useRegex) {
	var i;
		substrLen = substr.length;
		count = 0;

	if (useRegex) {
		var regex = new RegExp(substr, 'gi');
		return (text.match(regex)).length;
	}

	text = text.toLowerCase();
	substr = substr.toLowerCase();

	for (i = substrLen, len = text.length; i < len; i += 1) {
		if (text.substring(i - substrLen, i) === substr) {
			count += 1;
		}
	}

	return count;
}

console.log('Occurrences (regex) ->', countOccurrences(text, 'in', true));
console.log('Occurrences (iterative) ->', countOccurrences(text, 'in', false));