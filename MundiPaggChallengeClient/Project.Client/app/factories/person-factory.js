angular.module('app')
    .factory('personFactory', ['$http',
        function ($http) {
            var urlBase = "http://localhost:54243/api/person";

            var personFactory = {};

            personFactory.register = function (model) {
                return $http.post(urlBase + "/register", model);
            }

            return personFactory;
        }]);