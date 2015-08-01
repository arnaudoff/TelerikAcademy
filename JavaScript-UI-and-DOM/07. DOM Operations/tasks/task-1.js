/*

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element +
  * The provided id does not select anything (there is no element that has such an id) +
  * Any of the function params is missing +
  * Any of the function params is not as described +
  * Any of the contents is neither `string` or `number` +
	* In that case, the content of the element **must not be** changed
*/

module.exports = function () {
    return function (element, contents) {
        var domElement,
            divs,
            content,
            divElement,
            currentDiv;

        if (!element || !contents) {
            throw new Error('Both parameters should be present!');
        }

        if (typeof element !== 'string' && !(element instanceof HTMLElement)) {
            throw new Error('First parameter must be a string or an existing DOM element.');
        }

        if (!(contents instanceof Array)) {
            throw new Error('Second parameter should be an array.');
        }

        if (!element.id) {
            domElement = document.getElementById(element);
            if (!domElement) {
                throw new Error('Invalid id given!');
            }
        } else {
            domElement = element;
        }

        divs = document.createDocumentFragment();
        divElement = document.createElement('div');

        for (var i = 0, len = contents.length; i < len; i += 1) {
            content = contents[i];
            if (typeof content === 'string' || typeof content === 'number') {
                currentDiv = divElement.cloneNode(true);
                currentDiv.innerHTML = content;
            } else {
                throw new Error('The contents array must consist of strings and numbers only.');
            }

            divs.appendChild(currentDiv);
        }

        domElement.innerHTML = '';
        domElement.appendChild(divs);
    };
};