/*global angular*/

var WebChess = angular.module('WebChess', ['ngRoute']);

WebChess.config(['$routeProvider', function ($routeProvider) {
    'use strict';
    $routeProvider
        .when('/home', {
            templateUrl: 'partials/home.html',
            controller: 'HomeCtrl'
        })
        .when('/about', {
            templateUrl: 'partials/about.html'
        })
        .otherwise({
            redirectTo : '/home'
        });
}]);