(function() {

    var sammyApp = Sammy('#content', function() {
        var $content = $('#content');

        this.get('#/', function (context) {
            context.redirect('#/home');
        });

        this.get('#/home', homeController.all);

        this.get('#/my-cookie', cookiesController.myCookie);
        this.get('#/cookies', homeController.all); // ??
        this.get('#/cookies/share', cookiesController.share);

        this.get('#/categories', categoriesController.all);

        this.get('#/users', usersController.all);
        this.get('#/users/register', usersController.register);
        this.get('#/users/login', usersController.login);

    });

    $(function() {
        sammyApp.run('#/');

        if (data.users.hasUser()) {
            var username = data.users.getCurrent().username;
            var welcomeMessage = 'Welcome, ' + username;
            $('#user-control-menu').append('<li id="user-info"><a href="#">' + welcomeMessage + '</a></li>');
            $('#loginBtn').addClass('hidden');
            $('#registerBtn').addClass('hidden');
            $('#logoutBtn').on('click', function() {
                data.users.signOut()
                .then(function() {
                    document.location = '#/home';
                    document.location.reload(true);
                });
            });
        } else {
            $('#usersLink').attr('href', '#/users/login');
            $('#usersLink').on('click', function () {
                toastr.error('You must be logged in in order to view the users.');
            });
            $('#shareCookieLink').attr('href', '#/users/login');
            $('#shareCookieLink').on('click', function () {
                toastr.error('You must be logged in in order to share a cookie.');
            });
            $('#myCookieBtn').addClass('hidden');
            $('#logoutBtn').addClass('hidden');
            $('#user-info').addClass('hidden');
            $('#registerBtn').removeClass('hidden');
            $('#loginBtn').removeClass('hidden');
        }
    });
}());
