angular.module('app')
    .factory('itemFactory', ['$http',
        function ($http) {
            var urlBase = "http://localhost:54243/api/item";

            var itemFactory = {};

            itemFactory.list = function () {
                return $http.get(urlBase + "/list");
            };

            return itemFactory;
        }]);