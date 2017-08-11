'use strict'

angular.module('userprofile').
    component('userprofile', {
        templateUrl: '/Scripts/app/UserProfile/userprofile.template.html',
        controller: ['$http', UserProfileController]
    });