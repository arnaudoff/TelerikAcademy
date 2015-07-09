/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
	var course = (function () {
		var course = {
			init: function (title, presentations) {
				this.title = title;
				this.presentations = presentations;
                this.students = [];
                this.studentID = 0;
				return this;
			},
			addStudent: function (name) {
                if (checkStudentValidity(name)) {
                    this.students.push(name);
                }

                return this.studentID;
			},
			getAllStudents: function () {
                var result = this.students.map(function (name, studentID) {
                    return {
                        firstname : name.split(' ')[0],
                        lastname : name.split(' ')[1],
                        id : ++studentID
                    };
                });

                return result.slice();
			},
			submitHomework: function (studentID, homeworkID) {
                if (studentID > this.students.length || studentID < 1) {
                    throw new Error('Failed to submit homework: invalid student ID.');
                }

                if (homeworkID > this.presentations.length || homeworkID < 1) {
                    throw new Error('Failed to submit homework: invalid homework ID.');
                }
			},
			pushExamResults: function (results) {
                var currentIDs = [];
                results.forEach(function (item) {
                    if (item.StudentID > this.students.length || item.StudentID < 1) {
                        throw new Error('Failed to push exam results: invalid StudentID ' + item.StudentID);
                    }

                    if (currentIDs.indexOf(item.StudentID) > -1) {
                        throw new Error('Failed to push exam results: student ' + item.StudentID + ' already exists.');
                    }

                    if (typeof item.Score !== 'number') {
                        throw new Error('Score must be a number');
                    }

                    currentIDs.push(item.StudentID);
                });
			},
			getTopStudents: function () {
			}
		};

        Object.defineProperties(course, {
            'title': {
                get: function () {
                    return this._title;
                },
                set: function (value) {
                    if (checkTitleValidity(value)) {
                        this._title = value;
                    }
                }
            },
            'presentations': {
               get: function () {
                   return this._presentations;
               },
               set: function (value) {
                   if (value.length < 1) {
                       throw new Error("There must be at least one presentation for a course.");
                   }
                   if (value.every(checkTitleValidity)) {
                       this._presentations = value;
                   }
               }
            },
            'students': {
                get: function () {
                    return this._students;
                },
                set: function (value) {
                    this._students = value;
                }
            },
            'studentID': {
                get: function () {
                    return ++this._studentID;
                },
                set: function (value) {
                    this._studentID = value;
                }
            }
        });

        function checkTitleValidity(title) {
            if (title.length < 1) {
                throw new Error('Title must contain at least one character.');
            }

            if (/^\s+|\s+$/g.test(title)) {
                throw new Error('Title must not start or end with whitespace.');
            }

            if (/\s\s/g.test(title)) {
                throw new Error('Title must not contain consecutive spaces.');
            }

            return true;
        }

        function checkStudentValidity(name) {
            if (!/^[A-Z]{1}[a-z]* [A-Z]{1}[a-z]*$/g.test(name)) {
                throw new Error('Student names must be in the format Firstname Lastname.');
            }

            return true;
        }

		return course;
	} ());

	return course;
}

var courseSolve = solve();
var course = Object.create(courseSolve).init('JavaScript-OOP', ['Closures and Scopes', 'Prototype-based inheritance']);
console.log(course);
course.addStudent('Ivaylo Arnaudov');
course.addStudent('Toma Marinov');
console.log(course.getAllStudents());
module.exports = solve;
