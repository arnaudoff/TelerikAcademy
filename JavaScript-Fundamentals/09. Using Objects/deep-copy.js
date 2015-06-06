/*
	Write a function that makes a deep copy of an object.
	The function should work for both primitive and reference types.
*/

var student = {
	name : 'Gosho',
	age : 12,
	marks : {
		math : 6,
		programming : 6,
		history : 2
	}
};

function clone(obj) {
	// Handle primitive types
    if (typeof obj !== 'object') {
        return obj;
    }

    // Reference types
    var result = {};
    for (var prop in obj) {
        result[prop] = clone(obj[prop]);
    }

    return result;
}

console.log(clone(1337));
console.log(clone(student));