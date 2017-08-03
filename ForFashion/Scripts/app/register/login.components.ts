'use strict'

angular.module('login')
    .component('login', {
        templateUrl: '/Scripts/app/login/register.template.html',
        controller: ['$http', LoginController]
    });