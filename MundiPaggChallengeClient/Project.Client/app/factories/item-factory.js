angular.module('app')
    .factory('itemFactory', ['$http',
        function ($http) {
            var urlBase = "http://localhost:54243/api/item";

            var itemFactory = {};

            itemFactory.list = function () {
                return $http.get(urlBase + "/list");
            };

            itemFactory.filterByItemType = function (type) {
                return $http.get(urlBase + "/filterByItemType/" + type);
            }

            //resolved using angularjs $filter
            //itemFactory.filterByKeyWord = function (keyword) {
            //    return $http.get(urlBase + "/filterByKeyWord/" + keyword);
            //}

            itemFactory.filterByAvailability = function (loaned) {
                return $http.get(urlBase + "/filterByAvailability/" + loaned);
            }

            itemFactory.filterByMediaType = function (type) {
                return $http.get(urlBase + "/filterByMediaType/" + type);
            }

            return itemFactory;
        }]);