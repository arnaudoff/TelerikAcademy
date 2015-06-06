// Write a function that checks if a given object contains a given property.

var student = {
	name : 'Gosho',
	age : 12,
	marks : {
		math : 6,
		programming : 6,
		history : 2
	}
};

function removeProperty(obj, propName) {
	delete obj[propName];
}

function hasProperty(obj, prop) {
	return obj.hasOwnProperty(prop);
}

console.log(hasProperty(student, 'name'));
removeProperty(student, 'name');
console.log(hasProperty(student, 'name'));