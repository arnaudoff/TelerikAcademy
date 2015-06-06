/*
	Write a function that counts how many times given number appears in given array.
	Write a test function to check if the function is working correctly.
*/

var sampleArrays = {
	first : {
		contents : [5, 5, 2, 5, 4, 5, 1],
		number : 5,
		expectedResult : 4
	},
	second : {
		contents : [10, 20, 30, 40, 30, 30, 15],
		number: 30,
		expectedResult : 3
	}
};

function countOccurrences(arr, number) {
	var count = 0,
		i,
		arrLength = arr.length;

	for (i = 0; i < arrLength; i += 1) {
		if (arr[i] === number) {
			count += 1;
		}
	}

	return count;
}

function testOccurrences(sampleInput) {
	for (arr in sampleInput) {
		console.log('Searching for', sampleInput[arr].number, 'in', 
			sampleInput[arr].contents)
		console.log('\tExpected result:', sampleInput[arr].expectedResult);
		console.log('\tActual result:', countOccurrences(sampleInput[arr].contents, 
			sampleInput[arr].number));
	}
}

testOccurrences(sampleArrays);