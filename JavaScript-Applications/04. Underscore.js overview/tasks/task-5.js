function solve() {
    return function (animals) {
        if (!animals || !(animals instanceof Array)) {
            throw new Error('The function expects an array of animals!');
        }

        var totalNumberOfLegs = _.reduce(animals, function (memo, animal) {
            return memo + animal.legsCount;
        }, 0);

        console.log('Total number of legs: ' + totalNumberOfLegs);
    };
}

module.exports = solve;
