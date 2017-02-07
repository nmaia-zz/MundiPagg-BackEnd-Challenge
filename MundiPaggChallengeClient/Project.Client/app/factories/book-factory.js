angular.module('app')
    .factory('bookFactory', ['$http',
        function ($http) {
            var urlBase = "http://localhost:54243/api/book";

            var bookFactory = {};

            bookFactory.register = function (model) {
                return $http.post(urlBase + "/register", model);
            }

            return bookFactory;
        }]);