/*
	You are given a text. Write a function that changes the text in all regions:

		<upcase>text</upcase> to uppercase.
		<lowcase>text</lowcase> to lowercase
		<mixcase>text</mixcase> to mix casing (random)
*/

var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";

function parseTags(text) {
    var i,
        shift,
        currentTags = [],
        result = [];

    for (i = 0, len = text.length; i < len; i += 1) {
        if (text[i] === '<') {
            switch (text[i + 1]) {
                case 'u':
                    currentTags.push('u');
                    shift = text.indexOf('>', i);
                    i = shift + 1;
                    break;
                case 'l':
                    currentTags.push('l');
                    shift = text.indexOf('>', i);
                    i = shift + 1;
                    break;
                case 'm':
                    currentTags.push('m');
                    shift = text.indexOf('>', i);
                    i = shift + 1;
                    break;
                case '/':
                    currentTags.pop();
                    shift = text.indexOf('>', i);
                    i = shift + 1;
                    break;
            }
        }

        switch (currentTags[currentTags.length - 1]) {
            case undefined:
                result.push(text[i]);
                break;
            case 'u':
                result.push(text[i].toUpperCase());
                break;
            case 'l':
                result.push(text[i].toLowerCase());
                break;
            case 'm':
                if (Math.random() < 0.5) {
                    result.push(text[i].toLowerCase());
                    break;
                } else {
                    result.push(text[i].toUpperCase());
                    break;
                }
        }
    }

    return result.join('');
}

console.log(parseTags(text));