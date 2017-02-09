angular.module('app')
    .factory('itemFactory', ['$http',
        function ($http) {
            var urlBase = "http://localhost:54243/api/item";

            var itemFactory = {};

            itemFactory.list = function () {
                return $http.get(urlBase + "/list");
            };
                        
            itemFactory.listOnlyAvailableToLoan = function () {
                return $http.get(urlBase + "/list/onlyAvailableToLoan");
            };

            itemFactory.filterByItemType = function (type) {
                return $http.get(urlBase + "/filterByItemType/" + type);
            }

            itemFactory.getById = function (id) {
                return $http.get(urlBase + "/get/" + id);
            }

            itemFactory.delete = function (id) {
                return $http.delete(urlBase + "/delete/" + id);
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