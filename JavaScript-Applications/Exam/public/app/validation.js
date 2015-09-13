var validation = (function () {

    // Users

    function isValidUsername(username) {
        var expression = /^[a-zA-Z0-9_+]+$/;
        var regex = new RegExp(expression);
        if (typeof username === 'string' &&
            username.match(regex) &&
            username.length >= 6 &&
            username.length <= 30
        ) {
            return true;
        } else {
            return false;
        }
    }

    // Cookies

    function isValidCookieText(cookieText) {
        if (typeof cookieText === 'string' &&
            cookieText.length >= 6 &&
            cookieText.length <= 30
        ) {
            return true;
        } else {
            return false;
        }
    }

    function isValidCookieCategory(cookieCategory) {
        if (typeof cookieCategory === 'string' &&
            cookieCategory.length >= 6 &&
            cookieCategory.length <= 30
        ) {
            return true;
        } else {
            return false;
        }
    }

    function isValidCookieImage(cookieImageUrl) {
        var expression = /[-a-zA-Z0-9@:%_\+.~#?&//=]{2,256}\.[a-z]{2,4}\b(\/[-a-zA-Z0-9@:%_\+.~#?&//=]*)?/gi;
        var regex = new RegExp(expression);
        if (typeof cookieImageUrl === 'string' &&
            cookieImageUrl.match(regex)
        ) {
            return true;
        } else {
            return false;
        }
    }

    return {
        user: {
            isValidUsername: isValidUsername
        },
        cookie: {
            isValidCookieText: isValidCookieText,
            isValidCookieCategory: isValidCookieCategory,
            isValidCookieImage: isValidCookieImage
        }
    }
}());
