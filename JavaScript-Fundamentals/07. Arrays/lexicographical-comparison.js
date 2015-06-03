// Write a script that compares two char arrays lexicographically (letter by letter).

var firstArray = ['a', 'b', 'c'],
	secondArray = ['x', 'y', 'z'];


function compareArrays(firstArray, secondArray) {
	var i;
		firstLength = firstArray.length;
		secondLength = secondArray.length;
	
	if (firstLength > secondLength) {
		return 'The second array is lexicographically smaller than the first.';
	} else if (firstLength < secondLength) {
        return 'The first array is lexicographically smaller than the second.';
    } else {
		for (i = 0; i < firstLength; i += 1) {
			if (firstArray[i] < secondArray[i]) {
				return 'The first array is alphabetically smaller than the second.';
			}
			else if (firstArray[i] > secondArray[i]) {
				return 'The second array is alphabetically smaller than the first.';
			}
		}

		return 'The arrays are lexicographically and alphabetically equal.';
    }
}


console.log(compareArrays(firstArray, secondArray));