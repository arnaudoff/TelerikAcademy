var homeController = function() {
    function all(context) {
        var cookies;
        data.cookies.get()
        .then(function(resCookies) {
            if (context.params.category) {
                // the right way to achieve that would be on the server, not here but eh
                cookies = _.filter(resCookies, function (cookie) {
                    return cookie.category.toLowerCase() === context.params.category.toLowerCase();
                });
            } else {
                cookies = resCookies;
            }

            if (context.params.sortBy) {
                switch (context.params.sortBy) {
                    case 'likes':
                        cookies = _.sortBy(cookies, function (cookie) {
                            return -cookie.likes;
                        });
                        break;
                    case 'date':
                        cookies = _.sortBy(cookies, function (cookie) {
                            return -Date.parse(cookie.shareDate) / 1000;
                        });
                        break;
                    default:
                        context.redirect('#/');
                        break;
                }
            }

            cookies = _.each(cookies, function (cookie) {
                cookie.shareDate = moment(cookie.shareDate).fromNow();
                //cookie.userId = data.users.getUsernameById(cookie.userId);
            });

            return templates.get('home');
        })
        .then(function(template) {
            context.$element().html(template(cookies));

            $('.btn-like').on('click', function() {
                if (!data.users.hasUser()) {
                    // this sounds wrong on so many levels
                    toastr.error('You must be logged in in order to like cookies.');
                    return
                }

                var cookieId = $(this).data('id');
                data.cookies.like(cookieId)
                .then(function () {
                    toastr.success('Liked :)');
                    // TODO: Update the DOM to show the change instantly
                });
            });

            $('.btn-dislike').on('click', function() {
                if (!data.users.hasUser()) {
                    toastr.error('You must be logged in in order to dislike cookies.');
                    return;
                }

                var cookieId = $(this).data('id');
                data.cookies.dislike(cookieId)
                .then(function () {
                    toastr.info('Disliked :(');
                    // TODO: Update the DOM to show the change instantly
                });
            });

            $('#btn-sortby-category').on('click', function () {
                var categoryName = $('#tb-category-name').val();
                // TODO: some validation here..
                context.redirect('#/home?category=' + categoryName);
            });
        });
    }

    function byCategory(context) {

    }

    return {
        all: all,
        byCategory: byCategory
    };
}();
