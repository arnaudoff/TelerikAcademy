function solve() {
    return function (students) {
        if (!students || !(students instanceof Array)) {
            throw new Error('The function expects an array of students!');
        }

        _.chain(students).filter(function (student) {
            return student.firstName < student.lastName;
        }).map(function (student) {
            return {
                fullName: student.firstName + ' ' + student.lastName
            }
        }).sortBy('fullName').reverse()
        .each(function (student) {
          console.log(student.fullName);
        });
    };
}

module.exports = solve;
