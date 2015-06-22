/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(args) {
	var result = 0;

	if (args.length === 0) {
		return null;
	}

	if (!args) {
		throw Error;
	}

	args.forEach(function (item) {
		item = +item;
		if (isNaN(item)) {
			throw Error;
		} else {
			result += item;
		}
	});

	return result;
}

console.log(sum(['1', '2']));
module.exports = sum;