angular.module('app')
    .controller('media-controller',
                ['$scope', 'mediaFactory',
                    function ($scope, mediaFactory) {
                        $scope.genres = [
                            { id: 3, value: 'Movie' },
                            { id: 4, value: 'Music' },
                            { id: 5, value: 'Other' }
                        ];

                        $scope.medias = [
                            { id: 1, value: 'CD' },
                            { id: 2, value: 'DVD' }
                        ];

                        $scope.model = {
                            title: '',
                            registerDate: '',
                            releaseDate: '',
                            genre: '',
                            mediaType: ''
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

                            mediaFactory.register($scope.model)
                                .success(
                                    function () {
                                        $scope.message = "Media has been registered";

                                        $scope.model.title = '';
                                        $scope.model.registerDate = '';
                                        $scope.model.releaseDate = '';
                                        $scope.model.genre = '';
                                        $scope.model.mediaType = '';
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