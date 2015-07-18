/*jslint browser: true, devel: true */
/*global $, $http, WebChess, pieceFiles*/

WebChess.controller('HomeCtrl', ['$scope', 'pieceFiles', '$http', function ($scope, pieceFiles, $http) {
    'use strict';
    $http.get('http://localhost:8080').
        success(function (data) {
            $scope.board = data;
            $.each($scope.board, function (index, value) {
                $scope.board[index].file = pieceFiles.getFileName(value.name, value.color);
            });
            console.log($scope.board);
        });
}]);