// Write a script that finds the maximal sequence of equal elements in an array.

var sampleSequence = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];

function getMaximalSequence(array) {
	var currentValue = array[0],
		i,
		arrLength = array.length,
		currentCount = 1,
		maximalValueCount = 0,
		maximalElement = 0;

	for (i = 1; i < arrLength; i += 1) {
		if (currentValue === array[i]) {
			currentCount += 1;

			if (currentCount > maximalValueCount) {
				maximalValueCount = currentCount;
				maximalElement = array[i];
			}
		} else {
			if (currentCount > 1) {
				currentCount = 1;
			}

			currentValue = array[i];
		}
	}

	return Array.apply(null, new Array(maximalValueCount)).map(function(){
		return maximalElement;
	});
}

console.log(getMaximalSequence(sampleSequence));