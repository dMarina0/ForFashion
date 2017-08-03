'use strict'

angular.module('register')
    .component('register', {
        templateUrl: '/Scripts/app/register/register.template.html',
        controller: ['$http', RegisterController]
    });