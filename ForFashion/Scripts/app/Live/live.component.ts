'use strict'

angular.module('live').
    component('live', {
        templateUrl: '/Scripts/app/Live/live.template.html',
        controller: ['$rootScope', LiveController]
    });
       