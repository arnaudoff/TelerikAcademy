var data = (function() {
    const LOCAL_STORAGE_USERNAME = 'fortune-cookies-user',
    LOCAL_STORAGE_AUTHKEY = 'fortune-cookies-auth-key';

    // Users

    function register(user) {
        var reqUser = {
            username: user.username,
            passHash: CryptoJS.SHA1(user.username + user.password).toString()
        };

        var options = {
            data: reqUser
        };

        return ajaxRequest.post('api/users', options)
        .then(function (response) {
            var user = response.result;
            return user.username;
        });
    }


    function signIn(user) {
        var reqUser = {
            username: user.username,
            passHash: CryptoJS.SHA1(user.username + user.password).toString()
        };

        var options = {
            data: reqUser
        };

        return ajaxRequest.put('api/auth', options)
        .then(function (response) {
            var user = response.result;
            localStorage.setItem(LOCAL_STORAGE_USERNAME, user.username);
            localStorage.setItem(LOCAL_STORAGE_AUTHKEY, user.authKey);
            return user;
        });
    }

    function signOut() {
        return new Promise(function (resolve, reject) {
            localStorage.removeItem(LOCAL_STORAGE_USERNAME);
            localStorage.removeItem(LOCAL_STORAGE_AUTHKEY);
            resolve();
        });
    }

    function hasUser() {
        return !!localStorage.getItem(LOCAL_STORAGE_USERNAME) &&
        !!localStorage.getItem(LOCAL_STORAGE_AUTHKEY);
    }

    function getUsers() {
        var options = {
            headers: {
                'x-auth-key': localStorage.getItem(LOCAL_STORAGE_AUTHKEY)
            }
        }

        return ajaxRequest.get('api/users', options)
        .then(function (response) {
            return response.result;
        });
    }

    function getUsernameById(searchedId) {
        // TODO: Implement caching here since it iterates all users now
        var username;
        getUsers().then(function (users) {
            _.each(users, function (user) {
                if (user.id == searchedId) {
                    username = user.username;
                }
            });
        });

        return username;
    }

    function getCurrentUser() {
        return {
            username: localStorage.getItem(LOCAL_STORAGE_USERNAME),
            authKey: localStorage.getItem(LOCAL_STORAGE_AUTHKEY)
        }
    }

    // Cookies

    function shareCookie(cookie) {
        if (!cookie.img) {
            cookie.img = 'https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQ6lcfOGaOm_QjfhHNOS9MjjojLbNbCgyzueu4caAuQFVAEo67cMQ';
        }

        var options = {
            data: cookie,
            headers: {
                'x-auth-key': localStorage.getItem(LOCAL_STORAGE_AUTHKEY)
            }
        };

        return ajaxRequest.post('api/cookies', options)
        .then(function (response) {
            return response.result;
        });
    }

    function getCookies() {
        return ajaxRequest.get('api/cookies')
        .then(function (response) {
            return response.result;
        });
    }

    function likeCookie(cookieId) {
        var reqCookie = {
            type: 'like'
        };

        var options = {
            data: reqCookie,
            headers: {
                'x-auth-key': localStorage.getItem(LOCAL_STORAGE_AUTHKEY)
            }
        };

        return ajaxRequest.put('api/cookies/' + cookieId, options)
        .then(function (response) {
            return response.result;
        });
    }

    function dislikeCookie(cookieId) {
        var reqCookie = {
            type: 'dislike'
        };

        var options = {
            data: reqCookie,
            headers: {
                'x-auth-key': localStorage.getItem(LOCAL_STORAGE_AUTHKEY)
            }
        };

        return ajaxRequest.put('api/cookies/' + cookieId, options)
        .then(function (response) {
            return response.result;
        });
    }

    function getMyHourlyCookie() {
        var options = {
            headers: {
                'x-auth-key': localStorage.getItem(LOCAL_STORAGE_AUTHKEY)
            }
        };

        return ajaxRequest.get('api/my-cookie', options)
        .then(function (response) {
            return response.result;
        });
    }

    // Categories

    function getCategories() {
        return ajaxRequest.get('api/categories')
        .then(function (response) {
            return response.result;
        });
    }

    return {
        users: {
            signIn,
            signOut,
            register,
            hasUser,
            get: getUsers,
            getCurrent: getCurrentUser,
            getUsernameById: getUsernameById
        },
        cookies: {
            share: shareCookie,
            get: getCookies,
            like: likeCookie,
            dislike: dislikeCookie,
            getMyCookie: getMyHourlyCookie
        },
        categories: {
            get: getCategories
        }
    };
}());
