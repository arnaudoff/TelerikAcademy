/*
	Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
	Use the function from the previous exercise.
*/

var sampleArray = [15, 10, 2, 4, 1, 8, 2],
	index,
	newArr;

function isLargerThanNeighbours(arr, index) {
	if (typeof arr[index - 1] !== 'undefined' && typeof arr[index + 1] !== 'undefined') {
		return arr[index] > arr[index - 1] && arr[index] > arr[index + 1];
	}
}

function getFirstLargerThanNeighbours(arr) {
	var i,
		arrLength = arr.length;

	for (i = 1; i < arr.length; i += 1) {
		if (isLargerThanNeighbours(arr, i)) {
			return i;
		}
	}

	return -1;
}

index = getFirstLargerThanNeighbours(sampleArray);
console.log('Index:', index, 'Value:', sampleArray[index]);

newArr = sampleArray.slice(4, sampleArray.length); // [1, 8, 2]
newArr.push(3, 1); // [1, 8, 2, 3, 1]

index = getFirstLargerThanNeighbours(newArr);
console.log('Index:', index, 'Value:', newArr[index]);