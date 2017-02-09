angular.module('app')
    .controller('item-controller',
                ['$scope', 'itemFactory',
                    function ($scope, itemFactory) {

                        $scope.orderByField = 'Title';
                        $scope.reverseSort = false;

                        $scope.list = function () {
                            itemFactory.list()
                                .success(
                                    function (data) {

                                        data.forEach(function (element) {
                                            element.Loaned === true ? element.Loaned = "Yes" : element.Loaned = "No";
                                        });

                                        $scope.items = data;
                                    }
                                )
                                .error(
                                    function (errorMessage) {
                                        $scope.message = errorMessage;
                                    }
                                );
                        };

                        $scope.filterByItemType = function (type) {
                            itemFactory.filterByItemType(type)
                                .success(
                                    function (data) {

                                        data.forEach(function (element) {
                                            element.Loaned === true ? element.Loaned = "Yes" : element.Loaned = "No";
                                        });

                                        $scope.items = data;
                                    }
                                )
                                .error(
                                    function (errorMessage) {
                                        $scope.message = errorMessage;
                                    }
                                );
                        };

                        $scope.filterByAvailability = function (loaned) {
                            itemFactory.filterByAvailability(loaned)
                                .success(
                                    function (data) {

                                        data.forEach(function (element) {
                                            element.Loaned === true ? element.Loaned = "Yes" : element.Loaned = "No";
                                        });

                                        $scope.items = data;
                                    }
                                )
                                .error(
                                    function (errorMessage) {
                                        $scope.message = errorMessage;
                                    }
                                );
                        };

                        $scope.filterByMediaType = function (type) {
                            itemFactory.filterByMediaType(type)
                                .success(
                                    function (data) {

                                        data.forEach(function (element) {
                                            element.Loaned === true ? element.Loaned = "Yes" : element.Loaned = "No";
                                        });

                                        $scope.items = data;
                                    }
                                )
                                .error(
                                    function (errorMessage) {
                                        $scope.message = errorMessage;
                                    }
                                );
                        };

                        $scope.getById = function (id) {
                            itemFactory.getById(id)
                                .success(
                                    function (data) {

                                        data.Loaned == true ? data.Loaned = "Yes" : data.Loaned = "No";

                                        $scope.item = data;
                                    }
                                )
                                .error(
                                    function (e) {
                                        $scope.message = e;
                                    }
                                );
                        };

                        $scope.delete = function () {
                            itemFactory.delete($scope.item.Id)
                                .success(
                                    function () {
                                        $scope.list();
                                        $scope.message = "Item has been deleted.";
                                    }
                                )
                                .error(
                                    function (e) {
                                        $scope.message = e;
                                    }
                                );
                        };

                        $scope.edition = function () {

                            itemFactory.edition($scope.item)
                                .success(
                                    function () {
                                        $scope.list();
                                        $scope.message = "Loan has been updated.";
                                    }
                                )
                                .error(
                                    function (e) {
                                        $scope.message = e;
                                    }
                                );
                        };
                    }]);