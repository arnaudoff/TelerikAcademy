// Write a script that finds the most frequent number in an array.

var sampleArray = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];

function getMostFrequentNumber(array) {
    var mostFrequent,
        current,
        mostFrequentCount = 0,
        currentCount = 0,
        array,
        i,
        j,
        arrLength = array.length,
        result;

    for (i = 0; i < arrLength; i += 1) {
        current = array[i];
        currentCount = 0;
        for (j = i; j < arrLength; j += 1) {
            if (array[j] === current) {
                currentCount += 1;
                if (currentCount > mostFrequentCount) {
                    mostFrequentCount = currentCount;
                    mostFrequent = current;
                }
            }
        }
    }

    return [mostFrequent, mostFrequentCount];
}

var result = getMostFrequentNumber(sampleArray);
console.log(result[0] + ' (' + result[1] + ' times)');