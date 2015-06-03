// Write a script that finds the maximal increasing sequence in an arrayay.

var sampleSequence = [3, 2, 3, 4, 2, 2, 4];

function getMaxIncreasingSequence(array) {
    var max = [array[0]],
		tmp = [array[0]],
		arrLength = array.length;

    for (var i = 1; i < arrLength; i++) {
        if (array[i] > array[i - 1]) {
            tmp.push(array[i]);
        } else {
            tmp = [array[i]];
        }

        if (tmp.length > max.length) {
            max = tmp;
        }
    }

    return max;
}

console.log(getMaxIncreasingSequence(sampleSequence));