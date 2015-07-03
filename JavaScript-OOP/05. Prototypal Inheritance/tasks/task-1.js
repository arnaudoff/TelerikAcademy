/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/


/* Example

var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)

var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki">
<div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {
	'use strict';
	var domElement = (function () {
		var domElement = {
			init: function (type) {
				this.type = type;
				this.attributes = {};
				this.children = [];
				this.content = '';
				this.parent = null;
				return this;
			},
			appendChild: function (child) {
				if (typeof child !== 'string') {
                    child.parent = this;
				}

                this.children.push(child);
				return this;
			},
			addAttribute: function (name, value) {
				if (name === '' || (name.match(/[^\w\-]/))) {
					throw 'Only letters, digits and dashes are allowed.';
				}

				this.attributes[name] = value;
				return this;
			},
			removeAttribute: function(attribute) {
				if (!this.attributes[attribute]) {
                    throw 'Invalid attribute.';
				}

                delete this.attributes[attribute];
				return this;
			},
			get innerHTML() {
				return createInnerHtml(this);
			}
		};

		function createInnerHtml(obj) {
			var innerResult = '',
				result;
			if (obj.children.length > 0) {
				obj.children.forEach(function (item) {
					typeof item === 'string' ? innerResult += item : innerResult += item.innerHTML;
				});
				result = '<' + obj.type + parseAttributes(obj.attributes) + '>' + innerResult + '</' + obj.type + '>';
			} else {
				result = '<' + obj.type + parseAttributes(obj.attributes) + '>' + obj.content + '</' + obj.type + '>';
			}

			return result;
		}

		function parseAttributes(obj) {
			var result = ' ',
				attribute,
				attrArray = [];

			for (attribute in obj) {
				attrArray.push([attribute, obj[attribute]]);
			}

			attrArray.sort();
			attrArray.forEach(function (item) {
				result += item[0] + '="' + item[1] + '" ';
			});

			return result.trimRight();
		}

		Object.defineProperty(domElement, 'type', {
			get: function() {
				return this._type;
			},
			set: function(value) {
				if (value === '' || value.match(/[^\w]/)) {
					throw 'The type must be a non-empty string, containing only latin letters and digits.';
				}

				this._type = value;
			},
			enumerable: true
		});

		Object.defineProperty(domElement, 'content', {
			get: function() {
				return this._content;
			},
			set: function(value) {
				if (!this.hasChildren) {
					this._content = value;
				}
			},
			enumerable: true
		});

		return domElement;
	} ());

	return domElement;
}

module.exports = solve;
