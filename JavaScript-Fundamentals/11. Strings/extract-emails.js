/*
	Write a function for extracting all email addresses from given text.
	All sub-strings that match the format @… should be recognized as emails.
	Return the emails as array of strings.
*/

var text = "lorem.ipsum@dolor.sit amet, consectetur adipisicing elit. Impe.dit@qui.sed Veritatis aliquid consequuntur@maxime.dolore illo repudiandae quo@fugit.lol, eius ea. Minus alias a cupiditate accusantium@aut.com, sapiente ad.";

function extractEmails(text){
	// http://regexr.com/3b64u
    return text.match(/([a-zA-Z0-9.]+@[a-zA-Z0-9.]+\.[a-zA-Z0-9.]+)/gi);
}

console.log(extractEmails(text));