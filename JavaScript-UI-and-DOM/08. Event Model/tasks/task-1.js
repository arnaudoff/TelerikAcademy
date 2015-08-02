/*
 Create a function that takes an id or DOM element and:

 If an id is provided, select the element
 Finds all elements with class button or content within the provided element
    Change the content of all .button elements with "hide"
 When a .button is clicked:
    Find the topmost .content element, that is before another .button and:
    If the .content is visible:
        Hide the .content
        Change the content of the .button to "show"
    If the .content is hidden:
        Show the .content
        Change the content of the .button to "hide"
    If there isn't a .content element after the clicked .button and before other .button, do nothing
 Throws if:
    The provided DOM element is non-existent
    The id is either not a string or does not select any DOM element

*/

function solve() {
    return function (selector) {
        var element,
            buttons,
            i,
            len;

        if (selector === null || selector === undefined) {
            throw new Error('Null or undefined selector provided!');
        }

        if (selector instanceof HTMLElement) {
            element = selector;
        } else {
            if (typeof selector !== 'string') {
                throw new Error('The provided ID is not a string.');
            }

            element = document.getElementById(selector);

            if (!element) {
                throw new Error('The provided DOM element is non-existent');
            }
        }

        buttons = element.getElementsByClassName('button');

        for (i = 0, len = buttons.length; i < len; i += 1) {
            buttons[i].innerHTML = 'hide';
        }

        // Attach to parent element because attaching to every button would be an expensive operation.
        element.addEventListener('click', function (ev) {
            var clickedButton,
                nextContent,
                isContentVisible;

            if (ev.target.className.indexOf('button') >= 0) {
                clickedButton = ev.target;
                nextContent = clickedButton.nextElementSibling;
                while (nextContent && nextContent.className.indexOf('content') < 0) {
                    nextContent = nextContent.nextElementSibling;
                }

                isContentVisible = nextContent.style.display !== 'none';
                if (isContentVisible) {
                    nextContent.style.display = 'none';
                    clickedButton.innerHTML = 'show';
                } else {
                    nextContent.style.display = '';
                    clickedButton.innerHTML = 'hide';
                }
            }
        })
    };
}

module.exports = solve;