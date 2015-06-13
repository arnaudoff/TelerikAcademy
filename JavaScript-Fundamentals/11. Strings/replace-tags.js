/*
	Write a JavaScript function that replaces in a HTML document given as string 
	all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
*/

var input = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

function replaceTags(str) {
    while (str.indexOf('<a href') >= 0) {
        str = str.replace('<a href="', '[URL=')
				.replace('">', ']')
				.replace('</a>', '[/URL]');
    }

    return str;
}

console.log(replaceTags(input));