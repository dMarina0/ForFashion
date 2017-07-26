'use strict';

var myApp = angular.module('myApp', []);

    myApp.controller('signupController', ['$scope', '$window', 'signupService', function ($scope, $window, signupService) {

        $scope.init = function () {
            $scope.isProcessing = false;
        };

        $scope.init();

        $scope.registration = {
            Email: "",
            Password: "",
            ConfirmPassword: ""

        }
        $scope.signUp = function () {
            $scope.isProcessing = true;
            signupService.SaveRegistration($scope.registration).then(function (response) {
                alert("Registered");
                $window.location.href = 'Login.html';
            }, function (something) {
                var a = "";
                for (var key in something.data.ModelState) {
                    a = a + " " + something.data.ModelState[key].join();
                }
                debugger;
                alert(a);
                $scope.isProcessing = false;

            });
        };

    }]);

    myApp.factory('signupService', ['$http', function ($http) {

        var signupService = {};
        signupService.SaveRegistration = function (registration) {
            return $http.post('/api/Account/Register', registration)
        };

        return signupService;
  }])
