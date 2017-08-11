'use strict'

angular.module('videos', ['ngRoute'])
       .filter('trustedResource', videos.Filters.trustedResource.filter);