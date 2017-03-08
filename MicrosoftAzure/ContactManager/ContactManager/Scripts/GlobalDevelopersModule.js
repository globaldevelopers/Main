angular.module('GlobalDevelopers', [])

.controller('contactController', ['$scope', function ($scope) {

        'use strict';

        $scope.model = 'shalin';

        var test = 1;

    var result = test == 1;

    result = test === 1;

    test = null;

    result = test == 1;
    result = test === 1;

    result = test == 'null';
    result = test === null;

    result = test === 'null';
    }]);