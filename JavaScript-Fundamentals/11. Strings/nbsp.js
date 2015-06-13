// Write a function that replaces non breaking white-spaces in a text with &nbsp;

function replaceWhitespace(text) {
	// Note: \s matches whitespaces, /g is a modifier to search globally throughout the text
    return (text.split(/\s/g).join('&nbsp;'));
}

console.log(replaceWhitespace('Lorem ipsum sucks.'));