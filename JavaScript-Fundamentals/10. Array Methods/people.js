var people = [];

// Polyfill (from MDN)

if (!Array.prototype.find) {
	Array.prototype.find = function(predicate) {
		if (this === null) {
			throw new TypeError('Array.prototype.find called on null or undefined');
		}
		if (typeof predicate !== 'function') {
			throw new TypeError('predicate must be a function');
		}
		var list = Object(this);
		var length = list.length >>> 0;
		var thisArg = arguments[1];
		var value;

		for (var i = 0; i < length; i++) {
			value = list[i];
			if (predicate.call(thisArg, value, i, list)) {
				return value;
			}
		}
		return undefined;
	};
}

/*
	Write a function for creating persons.
	Each person must have firstname, lastname, age and gender (true is female, false is male)
*/

function createPerson(fname, lname, age, female) {
	return {
		firstName : fname,
		lastName : lname,
		age : age,
		isFemale : female
	};
}

function getRandomInt(min, max) {
	return Math.floor(Math.random() * (max - min)) + min;
}

// Generate an array with ten person with different names, ages and genders

function populatePeople() {
	var firstNames = ['Gergana', 'Mihaela', 'Maria', 'Teodora', 'Gabriela', 'Ivan', 'Vasko', 'Simon', 'Vesko', 'Mihail'],
		lastNames = ['Georgieva', 'Filipova', 'Ivanova', 'Hristova', 'Petkova', 'Marinov', 'Petrov', 'Georgiev', 'Marinov', 'Filipov'];
	
	for (i = 0; i < 10; i += 1) {
		people.push(createPerson(firstNames[i], lastNames[i], getRandomInt(1, 80), (i <= 4)));
	}
}

/*
	Write a function that checks if an array of person contains only people of age (with age 18 or greater)
	Use only array methods and no regular loops (for, while)
*/

function findPeopleOfAge(people) {
	return people.filter(function (person) {
		return person.age >= 18;
	});
}

/*
	Write a function that prints all underaged persons of an array of person
	Use Array#filter and Array#forEach
	Use only array methods and no regular loops (for, while)
*/

function findUnderagePeople(people) {
	var result = [];
	people.forEach(function (person) {
		if (person.age < 18) {
			result.push(person);
		}
	});

	return result;
}

/*
	Write a function that finds the youngest male person in a given array of people and prints his full name
	Use only array methods and no regular loops (for, while)
	Use Array#find
*/

function findYoungestMale(people) {
	var youngestMale = people.sort(function (firstPerson, secondPerson) { return firstPerson.age - secondPerson.age;} )
		.find(function (person) { return !person.isFemale; });

	return youngestMale.firstName + ' ' + youngestMale.lastName;
}

/*
	Write a function that calculates the average age of all females, extracted from an array of persons
	Use Array#filter
	Use only array methods and no regular loops (for, while)
*/

function calculateAverageAgeOfFemales(people) {
	var females = people.filter(function (person) { return person.isFemale; }),
		sum = females.reduce(function (sum, person) { return sum += person.age; }, 0);
	return sum / females.length;
}

function printPeople(people) {
	people.forEach(function (person) {
		var gender = person.isFemale ? 'Female' : 'Male';
		console.log(person.firstName + ' ' + person.lastName + ' (' + gender + ', ' + person.age + ')');
	});
}

/*
	Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
	Use Array#reduce
	Use only array methods and no regular loops (for, while)
*/

function groupPeople(people) {
	return people.reduce(function (group, person) {
		var firstLetter = person.firstName[0];

		if (group[firstLetter]) {
			group[firstLetter].push(person);
		} else {
			group[firstLetter] = [person];
		}

		return group;
	}, {});
}

populatePeople();

console.log('- People -');
printPeople(people);
console.log();
console.log('- People of age -');
printPeople(findPeopleOfAge(people));
console.log();
console.log('- Underage people -');
printPeople(findUnderagePeople(people));
console.log();
console.log('Average age of females ->', calculateAverageAgeOfFemales(people));
console.log('Youngest male ->', findYoungestMale(people));
console.log();
console.log(' - Grouped people -');
console.log(groupPeople(people));