angular.module('app')
    .controller('loan-controller',
                ['$scope', 'loanFactory', 'personFactory', 'itemFactory',
                    function ($scope, loanFactory, personFactory, itemFactory) {

                        $scope.listItems = function () {
                            itemFactory.listOnlyAvailableToLoan()
                                .success(
                                    function (data) {

                                        var result = [];

                                        data.forEach(function (element) {
                                            result.push({ id : element.Id, value: ( "(" + element.ItemType + ") " + element.Title) });
                                        });

                                        return $scope.items = result;
                                    }
                                )
                                .error(
                                    function (errorMessage) {
                                        $scope.message = errorMessage;
                                    }
                                );
                        };

                        $scope.listPersons = function () {
                            personFactory.list()
                                .success(
                                    function (data) {

                                        var result = [];

                                        data.forEach(function (element) {
                                            result.push({ id: element.Id, value: (element.FirstName + " " + element.LastName) });
                                        });

                                        return $scope.persons = result;
                                    }
                                )
                                .error(
                                    function (errorMessage) {
                                        $scope.message = errorMessage;
                                    }
                                );
                        };
                        
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

                            loanFactory.register($scope.model)
                                .success(
                                    function () {
                                        $scope.message = "Loan has been registered";

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