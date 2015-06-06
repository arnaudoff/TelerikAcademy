/*
	Write a function that removes all elements with a given value.
	Attach it to the array type.
*/

var sampleArray = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1,'1'];

Array.prototype.remove = function (item) {
    while (this.indexOf(item) >= 0) {
        this.splice(this.indexOf(item), 1);
    }

    return this;
};

console.log(sampleArray.remove(1));