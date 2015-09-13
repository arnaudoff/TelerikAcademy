function solve() {
    return function (students) {
        if (!students || !(students instanceof Array)) {
            throw new Error('The function expects an array of students!');
        }

        var bestAverageMarkStudent = _.chain(students).map(function (student) {
            if (!student.marks || !(student.marks instanceof Array)) {
                throw new Error('Each student should have an array of marks.');
            }

            return {
                fullName: student.firstName + ' ' + student.lastName,
                averageMark: _.reduce(student.marks, function (memo, mark) {
                    return memo + mark
                }, 0) / student.marks.length
            }

        }).max(function (student) {
            return student.averageMark;
        }).value();

        console.log(bestAverageMarkStudent.fullName + ' has an average' +
         ' score of ' + bestAverageMarkStudent.averageMark);
    };
}

module.exports = solve;
