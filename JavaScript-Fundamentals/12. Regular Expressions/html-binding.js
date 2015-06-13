/*
    Write a function that puts the value of an object into the content/attributes of HTML tags.
    Add the function to the String.prototype
*/

if (!String.hasOwnProperty('bind')) {
    String.prototype.bind = function(args) {
        var result;

        result = this.replace(/ data-bind-content="(.*?)".*?>/g,
            function(match, bindName) {
                return match + args[bindName];
            });

        result = result.replace(/ data-bind-(.*?)="(.*?)"/g,
            function(match, bindType, bindName) {
                if (bindType === 'content') {
                    return match;
                } else {
                    return match + ' ' + bindType + '="' + args[bindName] + '"';
                }
            });

        return result;
    };
}

var str = '<div data-bind-content="name"></div>';
console.log(str.bind({name: 'Steven'}));

var bindingString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></а>';
console.log(bindingString.bind({name: 'Elena', link: 'http://telerikacademy.com'}));