/*
	Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
	As a result print the values a and b, separated by a space.
*/

var a = 5.5;
var b = 4.5;

function exchange() {
	if (a > b) {
		var tmp = a;
		a = b;
		b = tmp;
	}
}

exchange();
console.log(a + ' ' + b);
