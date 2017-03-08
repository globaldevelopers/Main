WeatherForecast.controller("WeatherController", ["$scope", "$http", "WeatherService", function ($scope, $http, weatherService) {
    "use strict";

    $scope.GetWeather = function() {

        //$http.get('api/Home').then(function (response) {
        //    $scope.model = response.data;
        //});

        weatherService.get().then(function(response) {
            $scope.model = response.data;
        });
    };
}])