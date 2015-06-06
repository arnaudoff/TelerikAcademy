/*
	Write a function that checks if the element at given position in given array of integers 
	is bigger than its two neighbours (when such exist).
*/

var sampleArray = [5, 10, 5, 13, 8];

function isLargerThanNeighbours(arr, index) {
	if (typeof arr[index - 1] !== 'undefined' && typeof arr[index + 1] !== 'undefined') {
		return arr[index] > arr[index - 1] && arr[index] > arr[index + 1];
	}
}

console.log(isLargerThanNeighbours(sampleArray, 0)); // No left neighbour => undefined.
console.log(isLargerThanNeighbours(sampleArray, 1));
console.log(isLargerThanNeighbours(sampleArray, 3));
console.log(isLargerThanNeighbours(sampleArray, 2));