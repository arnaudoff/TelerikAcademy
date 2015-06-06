/*
	Write a function that finds the youngest person in a given array of people and prints his/hers full name
	Each person has properties firstname, lastname and age.
*/

var people = [
	{ firstname : 'Gosho', lastname : 'Petrov', age: 32 },
	{ firstname : 'Bay', lastname : 'Ivan', age: 64},
	{ firstname : 'Mitko', lastname : 'Todorov', age: 16},
	{ firstname : 'Vesko', lastname : 'Ivanov', age: 8}
];

function findYoungest(arr) {
	var youngest = arr[0],
		i,
		arrLength = arr.length;

	for (i = 1; i < arrLength; i += 1) {
		if (arr[i].age < youngest.age) {
			youngest = arr[i];
		}
	}

	return [youngest.firstname, youngest.lastname];
}

console.log(findYoungest(people).join(' '));