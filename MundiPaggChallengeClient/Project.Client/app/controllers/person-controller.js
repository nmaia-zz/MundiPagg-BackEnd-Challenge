angular.module('app')
    .controller('person-controller', 
                ['$scope', 'personFactory',
                    function ($scope, personFactory) {

                        $scope.genders = [
                            { id: 1, value: 'Male' },
                            { id: 2, value: 'Female' }
                        ];

                        $scope.model = {
                            firstName: '',
                            lastName: '',
                            birthDate: '',
                            gender: '',
                            cellphone: '',
                            email: ''
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

                            personFactory.register($scope.model)
                                .success(
                                    function () {
                                        $scope.message = "Person has been registered";

                                        $scope.model.firstName = '';
                                        $scope.model.lastName = '';
                                        $scope.model.birthDate = '';
                                        $scope.model.gender = '';
                                        $scope.model.cellphone = '';
                                        $scope.model.email = '';
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