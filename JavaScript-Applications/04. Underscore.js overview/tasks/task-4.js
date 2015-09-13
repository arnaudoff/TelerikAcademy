function solve() {
    return function (animals) {
        if (!animals || !(animals instanceof Array)) {
            throw new Error('The function expects an array of animals!');
        }

        var groups = _.chain(animals)
            .sortBy('species')
            .reverse()
            .groupBy('species')
            .value();

        _.each(_.keys(groups), function (group) {
            console.log(Array(group.length + 2).join('-'));
            console.log(group + ':');
            console.log(Array(group.length + 2).join('-'));

            _.chain(groups[group])
            .sortBy('legsCount')
            .each(function (animal) {
                console.log(animal.name + ' has ' + animal.legsCount + ' legs');
            });
        });
    };
}

module.exports = solve;
