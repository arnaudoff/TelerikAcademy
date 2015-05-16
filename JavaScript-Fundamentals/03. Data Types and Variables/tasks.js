// Assign all the possible JavaScript literals to different variables.

var fullName = 'Gosho' + ' ' + 'Petkanov';
var age = 50;
var currentMark = 5.50;
var marks = [2.50, 4.50, 3.20];
var isMale = true;
var func = function() { return; };
var obj = {goshoAge : age, goshoLife : life};

/*
	Create a string variable with quoted text in it.
	For example: `'How you doin'?', Joey said'.
*/

var quotedTest = "'How you doing?' Gosho said.";
console.log(quotedTest);

var allVariables = [fullName, age, currentMark, marks, isMale, func, obj, quotedTest];

// Try typeof on all variables you created.

for (var i = 0; i < allVariables.length; i++) {
	console.log(typeof allVariables[i]);
};

// Create null, undefined variables and try typeof on them.

var life = undefined; // ha ha
console.log('undefined: ' + typeof life);
life = null;
console.log('null: ' + typeof life);