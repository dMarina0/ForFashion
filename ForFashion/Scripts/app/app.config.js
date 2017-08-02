'use strict';
angular.
    module('ForFashionApp').
    config(['$locationProvider', '$routeProvider',
    function config($locationProvider, $routeProvider) {
        $locationProvider.hashPrefix('!');
        $routeProvider.
            when('/home', {
            template: '<home></home>'
        }).
            when('/fashionhouse', {
            template: '<fashionhouse></fashionhouse>'
        }).
            otherwise('/home');
    }
]);
//# sourceMappingURL=app.config.js.map