/*
	Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
	Return the elements in a JSON object.
*/

var url = "http://telerikacademy.com/Courses/Courses/Details/239";

function parseURL(url) {
	var proto = url.substring(0, url.indexOf(':'));
		srvStartingIndex = proto.length + 3;
		srv = url.substring(srvStartingIndex, url.indexOf('/', srvStartingIndex));
		rsrc = url.substring(srvStartingIndex + srv.length, url.length);
	return {
		protocol : proto,
		server : srv,
		resource : rsrc
	};
}

console.log(parseURL(url));