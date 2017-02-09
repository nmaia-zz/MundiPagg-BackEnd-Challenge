angular.module('app')
    .controller('book-controller', ['$scope', 'bookFactory',
        function ($scope, bookFactory) {

            $scope.genres = [
                { id: 1, value: 'Fiction' },
                { id: 2, value: 'Technical' },
                { id: 5, value: 'Other' }
            ];

            $scope.model = {
                title: '',
                registerDate: '',
                releaseDate: '',
                author: '',
                pages: '',
                publishingCompany: '',
                genre: ''
            };

            $scope.register = function () {

                //removing duplicity from array error message
                var unique = function (origArr) {
                    var newArr = [],
                        origLen = origArr.length,
                        found, x, y;

                    for (x = 0; x < origLen; x++) {
                        found = undefined;
                        for (y = 0; y < newArr.length; y++) {
                            if (origArr[x] === newArr[y]) {
                                found = true;
                                break;
                            }
                        }
                        if (!found) {
                            newArr.push(origArr[x]);
                        }
                    }
                    return newArr;
                }

                $scope.message = "Sending data, please wait...";
                $scope.error = "";
                $scope.validations = "";

                bookFactory.register($scope.model)
                    .success(
                        function () {
                            $scope.message = "Book has been registered";

                            $scope.model.title = '';
                            $scope.model.registerDate = '';
                            $scope.model.releaseDate = '';
                            $scope.model.author = '';
                            $scope.model.pages = '';
                            $scope.model.publishingCompany = '';
                            $scope.model.genre = '';
                        }
                    )
                    .error(
                        function (errorMessage, status) {

                            $scope.message = "";

                            if (status == 500) { 
                                $scope.error = errorMessage;
                            }
                            else if (status == 400) {

                                var arrUnique = unique(errorMessage);
                                $scope.validations = arrUnique;
                            }
                    });
            };
        }]);