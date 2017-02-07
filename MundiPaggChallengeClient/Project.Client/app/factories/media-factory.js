angular.module('app')
    .factory('mediaFactory', ['$http',
        function ($http) {
            var urlBase = "http://localhost:54243/api/media";

            var mediaFactory = {};

            mediaFactory.register = function (model) {
                return $http.post(urlBase + "/register", model);
            }

            return mediaFactory;
        }]);