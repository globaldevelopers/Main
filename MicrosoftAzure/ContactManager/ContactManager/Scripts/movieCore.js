angular.module('movieCore', ['ngResource'])
    .factory('popularMovies', function ($resource) {
        return $resource('popular/:movieId', { movieid: '@id' }, {
            update: {
                method: 'PUT'
            }
        });
    });