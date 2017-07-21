'use strict';
var myApp = angular.module('myApp', []);

myApp.controller('signupController', ['$scope','$window','signupService',function($scope,$window,signupService){

    $scope.registration = {
        Email: "",
        Password: "",
        ConfirmPassword:""

    }
    $scope.signUp = function () {
        signupService.saveRegistration($scope.registration).then(function () {
            alert("Registered");
        },function(){
            alert("Failed");
        
        })
    }



}])

myApp.factory('signupService', ['$http', function ($htpp) {

    signupService = {};
    signupService.SaveRegistration = function (registration) {
        return $http.post('/api/account/register',registration)
    }

    return signupService;
})