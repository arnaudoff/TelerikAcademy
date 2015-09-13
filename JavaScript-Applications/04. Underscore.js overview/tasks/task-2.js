function solve() {
    return function (students) {
        if (!students || !(students instanceof Array)) {
            throw new Error('The function expects an array of students!');
        }

        _.chain(students).filter(function (student) {
            return student.age >= 18 && student.age <= 24;
        }).map(function (student) {
            return {
                fullName: student.firstName + ' ' + student.lastName
            }
        }).sortBy('fullName')
        .each(function (student) {
            console.log(student.fullName);
        });
    };
}

module.exports = solve;
