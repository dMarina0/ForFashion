'use strict';

// Declare app level module which depends on views, and components
angular.module('myApp', [
    'ngRoute',
]).
    config(['$locationProvider', '$routeProvider', function ($locationProvider, $routeProvider) {
        $locationProvider.hashPrefix('!');

        $routeProvider.
            when('/register', {
                template: '<register></register>'
            }).
            
            otherwise('/phones');
    }]);