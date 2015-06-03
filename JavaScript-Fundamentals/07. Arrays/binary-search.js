// Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.

var sampleArray = [13, 7, 2, 6, 3, 15, 1, 1, 8, 33, 9, 39, 81],
    numberToFind = 81;
    
function sortNumber(a, b) {
    return a - b;
}

function binarySearch(array, num, min, max) {
    var mid = min + Math.floor((max - min) / 2);
    
    if (max < min || num > array[max]) {
        return -1;
    }

    if (array[mid] > num) {
        return binarySearch(array, num, min, mid - 1);
    } else if (array[mid] < num) {
        return binarySearch(array, num, mid + 1, max);
    } else {
        return mid;
    }
}

sampleArray.sort(sortNumber);

console.log(binarySearch(sampleArray, numberToFind, 0, sampleArray.length - 1));