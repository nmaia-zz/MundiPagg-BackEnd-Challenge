angular.module('app')
    .controller('item-controller',
                ['$scope', 'itemFactory',
                    function ($scope, itemFactory) {

                        $scope.list = function () {
                            itemFactory.list()
                                .success(
                                    function (data) {
                                        $scope.items = data;
                                    }
                                )
                                .error(
                                    function (errorMessage) {
                                        $scope.message = errorMessage;
                                    }
                                );
                        };

                        $scope.orderByField = 'Title';
                        $scope.reverseSort = false;

                    }]);