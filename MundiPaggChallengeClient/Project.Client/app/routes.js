app.config(['$routeProvider',
    function ($routeProvider) {
        $routeProvider
            // begin - book routes
            .when(
                '/item/list', //url
                {
                    templateUrl: '/app/views/item/list.html',
                    controller: 'item-controller'
                }
            )
            // end - book routes

            // begin - book routes
            .when(
                '/book/register', //url
                {
                    templateUrl: '/app/views/book/register.html',
                    controller: 'book-controller'
                }
            )
            // end - book routes

            // begin - media routes
            .when(
                '/media/register', //url
                {
                    templateUrl: '/app/views/media/register.html',
                    controller: 'media-controller'
                }
            )
            // end - media routes

            // begin - person routes
            .when(
                '/person/register', //url
                {
                    templateUrl: '/app/views/person/register.html',
                    controller: 'person-controller'
                }
            )
            // end - person routes

            // begin - loan routes
            .when(
                '/loan/register', //url
                {
                    templateUrl: '/app/views/loan/register.html',
                    controller: 'loan-controller'
                }
            )
            // end - loan routes

            .otherwise(
                {
                    redirect: '/index.html'
                }
            );
    }
]);