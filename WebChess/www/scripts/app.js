var WebChess = angular.module("WebChess", []);

WebChess.config(['$routeProvider',function($routeProvider) {
    
    $routeProvider
    
    .when('/home', {
        templateUrl: 'home.html',
        controller: 'HomeController',
    })
    .otherwise({
        redirectTo : '/home'
    });
}]);