// Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

function getProperties(obj) {
    var smallest = 0;
    var largest = 0;

    for (var property in obj) {
        if (!smallest) {
            smallest = property;
        }
        
        if (!largest) {
            largest = property;
        }

        if (property < smallest) {
            smallest = property;
        }

        if (property > largest) {
            largest = property;
        }
    }

    console.log('Lexicographically smallest: ' + smallest);
    console.log('Lexicographically largest: ' + largest + '\n\r');
}

console.log('Window object: ');
getProperties(window);
console.log('Navigator object: ');
getProperties(navigator);
console.log('Document object: ');
getProperties(document);