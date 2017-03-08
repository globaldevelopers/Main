WeatherForecast.service("WeatherService", function($http, $q) {
    var service = {};

    function httpPromise(url) {
        var deferred = $q.defer();

        $http.get(url)
            .then(function(data) {
                deferred.resolve(data);
            });

        return deferred.promise;
    };

    service.get = function() {
        return httpPromise('api/Weather');
    };

    return service;
})