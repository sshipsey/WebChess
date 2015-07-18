/*global WebChess*/

WebChess.factory('pieceFiles', function () {
    'use strict';
    return {
        getFileName: function (piece, color) {

            var pieceFile = 'img/';

            if (color === 0) {
                pieceFile += 'white';
            } else {
                pieceFile += 'black';
            }
            switch (piece) {
            case 'Rook':
                pieceFile += 'rook';
                break;
            case 'King':
                pieceFile += 'king';
                break;
            case 'Bishop':
                pieceFile += 'bishop';
                break;
            case 'Queen':
                pieceFile += 'queen';
                break;
            case 'Pawn':
                pieceFile += 'pawn';
                break;
            case 'Knight':
                pieceFile += 'knight';
                break;
            default:
                pieceFile = 'blank';
            }
            pieceFile += '.svg';
            return pieceFile;
        }
    };
});