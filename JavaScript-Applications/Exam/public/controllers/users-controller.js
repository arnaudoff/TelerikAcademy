var usersController = function() {
    function all(context) {
        var users;
        data.users.get()
        .then(function(resUsers) {
            users = resUsers;
            return templates.get('users');
        })
        .then(function(template) {
            context.$element().html(template(users));
        });
    }

    function register(context) {
        templates.get('register')
        .then(function (template) {
            context.$element().html(template());

            $('#btn-register').on('click', function() {
                var user = {
                    username: $('#tb-registration-username').val(),
                    password: $('#tb-registration-password').val()
                };

                if (!validation.user.isValidUsername(user.username)) {
                    toastr.error('Username is invalid.');
                    return;
                }

                data.users.register(user)
                .then(function() {
                    context.redirect('#/users/login');
                    document.location.reload(true);
                });
            });

            $('#btn-register-reset').on('click', function () {
                $('#tb-registration-username').val(''),
                $('#tb-registration-password').val('')
            });
        });
    }

    function login(context) {
        templates.get('login')
        .then(function (template) {
            context.$element().html(template());

            $('#btn-login').on('click', function() {
                var user = {
                    username: $('#tb-login-username').val(),
                    password: $('#tb-login-password').val()
                };

                console.log('here');
                data.users.signIn(user)
                .then(function() {
                    context.redirect('#/');
                    document.location.reload(true);
                });
            });

            $('#btn-login-reset').on('click', function () {
                $('#tb-login-username').val(''),
                $('#tb-login-password').val('')
            });
        });
    }
    return {
        all: all,
        register: register,
        login: login
    };
}();
