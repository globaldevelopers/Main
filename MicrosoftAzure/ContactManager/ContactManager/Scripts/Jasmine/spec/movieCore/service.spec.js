describe('movieCore', function() {
    var popularMovies;
    var $httpBackend;

    beforeEach(module('movieCore'));

    beforeEach(inject(function(_popularMovies_, _$httpBackend_) {
        popularMovies = _popularMovies_;
        $httpBackend = _$httpBackend_;
    }));

    afterEach(function() {
        $httpBackend.verifyNoOutstandingExpectation();
    });


    it('should create popular movie', function () {

        var expectedData = function(data) {

            console.log(angular.mock.dump(data));
            return angular.fromJson(data).movieId === 't0076759';
        }

        $httpBackend.expectPOST(/./, expectedData)
            .respond(201);

        var popularMovie = new popularMovies({
            movieId: 't0076759',
            description: 'Great movie!'
        });

        popularMovie.$save();

        expect($httpBackend.flush).not.toThrow();
    });

    it('should get popular movie by id', function() {

        $httpBackend.expectGET('popular/tt007659')
        .respond(200);

        popularMovies.get({ movieId: 'tt007659' });

        expect($httpBackend.flush).not.toThrow();
    });

    it('should update popular movie', function() {

        $httpBackend.expectPUT('popular')
       .respond(200);

        var popularMovie = new popularMovies({
            movieId: 't0076759',
            description: 'Great movie!'
        });

        popularMovie.$update();

        expect($httpBackend.flush).not.toThrow();
    });
});