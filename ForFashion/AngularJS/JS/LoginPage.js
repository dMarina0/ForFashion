///<reference path="angular.js" />
'use strict';

var loginApp = angular.module('loginApp', ['AuthApp']);


loginApp.controller('loginController', ['$scope', '$window', 'authService', function ($scope, $window, authService) {

    $scope.init = function () {
        $scope.isProcessing = false;
        // $scope.LoginBtnText = "Sign in";
    }
    $scope.init();
    $scope.loginData = {
        userName: "",
        password: ""
    };

    $scope.Login = function (loginData) {
        $scope.isProcessing = true;
        // $scope.LoginBtnText = "Signing in ...";
        authService.login($scope.loginData).then(function (response) {
            alert("Login Successfully");
        }, function () {
            alert("Failed.Please try again.")
            $scope.init();
        })

    }

}])
