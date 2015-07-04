/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/

function solve() {
    String.format = function() {
        var s = arguments[0];
        for (var i = 0; i < arguments.length - 1; i++) {
            var reg = new RegExp("\\{" + i + "\\}", "gm");
            s = s.replace(reg, arguments[i + 1]);
        }
        return s;
    };

	var Person = (function () {
		function Person(firstname, lastname, age) {
			this.firstname = firstname;
			this.lastname = lastname;
			this.age = age;
            this.fullname = firstname + ' ' + lastname;
		}

		function checkNameValidity(name, min, max, propName) {
			if (name.length < min || name.length > max) {
				throw new Error("The name must be between 3 and 20 characters. (" + propName + ")");
			}

            // Disclaimer: .test() is faster than match
            if(!/^[a-zA-Z]+$/.test(name)) {
                throw new Error("The name must contain only latin letters. (" + propName + ")");
            }

			return true;
		}

		Object.defineProperties(Person.prototype, {
			'firstname': {
				get: function () {
					return this._firstname;
				},
				set: function (value) {
					if (typeof value !== 'string') {
						throw new Error('The name must be a string. (firstname)');
					}

					if (checkNameValidity(value, 3, 20, 'firstname')) {
						this._firstname = value;
					}

                    return this;
				}
			},
			'lastname': {
				get: function () {
					return this._lastname;
				},
				set: function (value) {
					if (typeof value !== 'string') {
						throw new Error('The name must be a string. (lastname)');
					}

					if (checkNameValidity(value, 3, 20, 'lastname')) {
						this._lastname = value;
					}

                    return this;
				}
			},
			'age': {
				get: function () {
					return this._age;
				},
				set: function (value) {
					if (+value < 0 || +value > 150) {
						throw new Error('Age is not in range (0; 150).');
					}

                    this._age = value;
                    return this;
				}
			},
			'fullname': {
				get: function () {
					return this._fullname;
				},
				set: function (value) {
					var names = value.split(' ');
					this.firstname = names[0];
					this.lastname = names[1];
					this._fullname = names[0] + ' ' + names[1];

                    return this;
				}
			}
		});

		Person.prototype.introduce = function () {
			return String.format("Hello! My name is {0} and I am {1}-years-old", this.fullname, this.age);
		};

		return Person;
	} ());

	return Person;
}

module.exports = solve;