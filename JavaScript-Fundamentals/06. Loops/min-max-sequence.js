// Write a script that finds the max and min number from a sequence of numbers.

var sequence = [5, 3, 84, 45, 5];

function getMin(sequence) {
	var min = sequence[0],
		i = 1,
		length = sequence.length; 
	for (i; i < length; i += 1) {
		if (sequence[i] < min) {
			min = sequence[i];
		}
	}

	return min;
}

function getMax(sequence) {
	var max = sequence[0],
		i = 1,
		length = sequence.length; 
	for (i; i < length; i += 1) {
		if (sequence[i] > max) {
			max = sequence[i];
		}
	}

	return max;
}

console.log(getMax(sequence));
console.log(getMin(sequence));