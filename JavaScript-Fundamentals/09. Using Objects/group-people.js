/*
	Write a function that groups an array of people by age, first or last name.
	The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
	Use function overloading (i.e. just one function)
*/

var people = [
	{ firstname : 'Gosho', lastname : 'Petrov', age: 32 },
	{ firstname : 'Ivan', lastname : 'Ivanov', age: 32},
	{ firstname : 'Mitko', lastname : 'Todorov', age: 16},
	{ firstname : 'Vesko', lastname : 'Ivanov', age: 16},
	{ firstname : 'Gosho', lastname : 'Georgiev', age: 8}
];

function group(people, prop) {
	var result = {},
		tempProp;

	for (var i in people) {
		// In order to push, we have to define the value as an array
		if (!result.hasOwnProperty(people[i][prop])) {
			result[people[i][prop]] = [];
		}

		result[people[i][prop]].push(people[i]);
	}

	return result;
}

console.log(group(people, 'age'));