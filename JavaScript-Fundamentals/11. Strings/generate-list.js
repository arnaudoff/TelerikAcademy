/*
	Write a function that creates a HTML <ul> using a template for every HTML <li>.
	The source of the list should be an array of elements.
	Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
*/

var people = [{
		name: 'Gosho',
		age: 12
	}, {
		name: 'Pesho',
		age: 13
	}, {
		name: 'Ivancho',
		age: 13
	}, {
		name: 'Mariika',
		age: 10
	}],
	tmpl = document.getElementById('list-item').innerHTML;

// Open generate-list.html to see it in action!

function generateList() {
    var ul = document.createElement('ul');

    for (var prop in people) {
        var li = document.createElement('li');
        li.innerHTML = format(tmpl, people[prop]);
        ul.appendChild(li);
    }

    document.body.appendChild(ul);
}

function format(string, person){
	// http://regexr.com/3b65m
    return string.replace(/\-{(\w+)\}-/g, function (match, prop) {
        return person[prop];
    });
}