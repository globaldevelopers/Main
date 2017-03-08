angular.module('omdb', [])
    .factory('omdbApi', function ($http, $q) {
        var service = {};

        var baseUrl = "http://www.omdbapi.com/?v=1&";

        function httpPromise(url) {
            var deferred = $q.defer();

            $http.get(url)
                .then(function (data) {
                    deferred.resolve(data);
                });

            return deferred.promise;
        }

        service.search = function (query) {
            return httpPromise(baseUrl + "s=" + encodeURIComponent(query));
        };

        service.find = function(id) {
            return httpPromise(baseUrl + "i=" + id);
        };

        return service;

    })
    .controller('movieController', ['$scope', '$http', function($scope, $http) {
        $scope.model = { name: "movie shalin" };

            $scope.test = function() {
                
                $http.get('api/MoviesData').then(function (data) {
                    $scope.model.name = data.data;
                });
            };
        }
    ]);