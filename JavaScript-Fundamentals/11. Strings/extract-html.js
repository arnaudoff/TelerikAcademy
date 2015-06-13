/*
	Write a function that extracts the content of a html page given as text.
	The function should return anything that is in a tag, without the tags.
*/

var contents = "<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>";

function extractHTML(text) {
	var result = '',
		i;

	for (i = 0, len = text.length; i < len; i += 1) {
		if (text[i] === '<') {
			i = text.indexOf('>', i);
		} else {
			result += text[i];
		}
	}

	return result;
}

console.log(extractHTML(contents));