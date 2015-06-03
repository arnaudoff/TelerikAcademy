/*
	Write a script to sort an array.
	Use the selection sort algorithm: Find the smallest element,
	move it at the first position, find the smallest from the rest, move it at the second position, etc.
*/

var sampleArray = [13, 7, 2, 6, 3, 15, 1, 1, 8, 33, 9, 39, 81];

function sort(array) {
	var left,
		right,
		tmp,
		arrLength = array.length;

	for (left = 0; left < arrLength; left++) {
		for (right = left + 1; right < arrLength; right++) {
			if (array[left] > array[right]) {
				tmp = array[right];
				array[right] = array[left];
				array[left] = tmp;
			}
		}
	}
}

sort(sampleArray);

console.log(sampleArray);