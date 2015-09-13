var categoriesController = function() {
    function all(context) {
        var categories;
        data.categories.get()
        .then(function(resCategories) {
            categories = resCategories;
            return templates.get('categories');
        })
        .then(function(template) {
            context.$element().html(template(categories));
        });
    }

    return {
        all: all
    }
}();
