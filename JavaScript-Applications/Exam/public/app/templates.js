var templates = function() {
    var handlebars = window.handlebars || window.Handlebars,
    Handlebars = window.handlebars || window.Handlebars,
    cache = {};

    function get(name) {
        return new Promise(function (resolve, reject) {
            if (cache[name]) {
                resolve(cache[name]);
                return;
            }

            var url = `templates/${name}.handlebars`;

            $.get(url, function (html) {
                var template = handlebars.compile(html);
                cache[name] = template;
                resolve(template);
            });
        });
    }

    return {
        get: get
    };
}();
