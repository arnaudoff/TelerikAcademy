var cookiesController = function() {
    function share(context) {
        templates.get('cookie-share')
        .then(function (template) {
            context.$element().html(template());

            $('#btn-share').on('click', function() {
                var cookie = {
                    text: $('#tb-cookieshare-text').val(),
                    category: $('#tb-cookieshare-category').val(),
                    img: $('#tb-cookieshare-image').val()
                };

                if (!validation.cookie.isValidCookieText(cookie.text)) {
                    toastr.error('Invalid cookie text!');
                    return;
                }

                if (!validation.cookie.isValidCookieCategory(cookie.category)) {
                    toastr.error('Invalid cookie category!');
                    return;
                }

                if (!validation.cookie.isValidCookieImage(cookie.img)) {
                    toastr.error('Invalid cookie image url.');
                    return;
                }

                data.cookies.share(cookie)
                .then(function() {
                    context.redirect('#/');
                    document.location.reload(true);
                });
            });

            $('#btn-share-reset').on('click', function () {
                $('#tb-cookieshare-text').val(''),
                $('#tb-cookieshare-category').val(''),
                $('#tb-cookieshare-image').val('')
            });
        });
    }

    function myCookie(context) {
        var cookie;
        data.cookies.getMyCookie()
        .then(function(resCookie) {
            cookie = resCookie;
            cookie.shareDate = moment(cookie.shareDate).fromNow();
            return templates.get('my-cookie');
        })
        .then(function(template) {
            context.$element().html(template(cookie));
        });
    }

    return {
        share: share,
        myCookie: myCookie
    };
}();
