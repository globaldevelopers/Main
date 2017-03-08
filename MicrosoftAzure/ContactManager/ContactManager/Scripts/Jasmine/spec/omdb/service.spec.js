describe('omdb service', function() {
    var movieData = { "Title": "Dark Places", "Year": "2015", "Rated": "R", "Released": "18 Jun 2015", "Runtime": "113 min", "Genre": "Drama, Mystery, Thriller", "Director": "Gilles Paquet-Brenner", "Writer": "Gilles Paquet-Brenner, Gillian Flynn (novel)", "Actors": "Charlize Theron, Sterling Jerins, Nicholas Hoult, Christina Hendricks", "Plot": "Libby Day was only eight years old when her family was brutally murdered in their rural Kansas farmhouse. Almost thirty years later, she reluctantly agrees to revisit the crime and uncovers the wrenching truths that led up to that tragic night.", "Language": "English", "Country": "UK, France, USA", "Awards": "N/A", "Poster": "https://images-na.ssl-images-amazon.com/images/M/MV5BMTY1NTM4ODYzM15BMl5BanBnXkFtZTgwNTY2NDIwNjE@._V1_SX300.jpg", "Metascore": "39", "imdbRating": "6.2", "imdbVotes": "29,711", "imdbID": "tt2402101", "Type": "movie", "Response": "True" };

    var movieDataById = { "Title": "Star Wars: Episode IV - A New Hope", "Year": "1977", "Rated": "PG", "Released": "25 May 1977", "Runtime": "121 min", "Genre": "Action, Adventure, Fantasy", "Director": "George Lucas", "Writer": "George Lucas", "Actors": "Mark Hamill, Harrison Ford, Carrie Fisher, Peter Cushing", "Plot": "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a wookiee and two droids to save the galaxy from the Empire's world-destroying battle-station, while also attempting to rescue Princess Leia from the evil Darth Vader.", "Language": "English", "Country": "USA", "Awards": "Won 6 Oscars. Another 48 wins & 28 nominations.", "Poster": "https://images-na.ssl-images-amazon.com/images/M/MV5BYzQ2OTk4N2QtOGQwNy00MmI3LWEwNmEtOTk0OTY3NDk2MGJkL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_SX300.jpg", "Metascore": "92", "imdbRating": "8.7", "imdbVotes": "945,400", "imdbID": "tt0076759", "Type": "movie", "Response": "True" };

    var omdbApi = {};
    var $httpBackend;

    beforeEach(module('omdb'));

    beforeEach(inject(function(_omdbApi_, _$httpBackend_) {
    	omdbApi = _omdbApi_;
        $httpBackend = _$httpBackend_;
    }));

    it('should return search movie data', function () {
    	var response;

        $httpBackend.when('GET', 'http://www.omdbapi.com/?v=1&s=dark%20places')
            .respond(200, movieData);

        omdbApi.search('dark places').then(function(data) {
            response = data;
        });

        $httpBackend.flush();

        expect(response.data).toEqual(movieData);
    });

    it('should return movie data by id', function () {
    	var response;

    	$httpBackend.when('GET', 'http://www.omdbapi.com/?v=1&i=tt0076759')
            .respond(200, movieDataById);

    	omdbApi.find('tt0076759').then(function (data) {
    		response = data;
    	});

    	$httpBackend.flush();


    	expect(response.data).toEqual(movieDataById);
    });
});