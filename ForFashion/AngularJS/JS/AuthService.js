/// <reference path="angular.js" />

'use strict';

var AuthApp = angular.module('AuthApp', ['LocalStorageModule']);




AuthApp.factory('authService', ['$http', '$q', 'localStorageService', function ($http, $q, localStorageService) {
    var authServiceFactory = {};

    var _authentication = {
        isAuth: false,
        userName: ""
    };

    authServiceFactory.saveRegistration = function (registration) {

       

        return $http.post('/api/Account/Register', registration)
    };

    authServiceFactory.login = function (loginData) {

        var data = "grant_type=password&username=" + loginData.userName + "&password=" + loginData.password;

        var deferred = $q.defer();

        $http.post('/token', data, {
            header: { 'Content-Type': 'application/x-www-form-urlencoded' }
        }).then(function successCallback(response) {
            localStorageService.set('authorizationData', { token: response.access_token, userName: response.userName });

            _authentication.isAuth = true;
            _authentication.userName = loginData.userName;

            deferred.resolve(response);
        }, function errorCallback(response) {
            
            deferred.reject(response);
        });

        return deferred.promise;
    };
    authServiceFactory.logOut = function () {

        localStorageService.remove('authorizationData');

        _authentication.isAuth = false;
        _authentication.userName = "";
    };

    authServiceFactory.fillAuthData = function () {
        var authData = localStorageService.get('authorizationData');
        if (authData) {
            _authentication.isAuth = true;
        }
        else {
            _authentication.isAuth = false;
        }
    };

    authServiceFactory.changePassword = function (passwordData) {

        return $http.post('/api/Account/ChangePassword', passwordData)

    };

    return authServiceFactory;
}]);