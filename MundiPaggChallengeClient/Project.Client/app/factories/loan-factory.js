angular.module('app')
    .factory('loanFactory', ['$http',
        function ($http) {
            var urlBase = "http://localhost:54243/api/loan";

            var loanFactory = {};

            loanFactory.register = function (model) {
                return $http.post(urlBase + "/register", model);
            }

            return loanFactory;
        }]);