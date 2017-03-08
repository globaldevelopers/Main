describe("Weather service", function() {
    var weatherService = {};

    var $httpBackend;

    var weatherData = "Date: 2017-01-01, Temp: 3.5";

    beforeEach(module('WeatherForecast'));

    // ReSharper disable InconsistentNaming
    beforeEach(inject(function(_WeatherService_, _$httpBackend_) {
        weatherService = _WeatherService_;
        $httpBackend = _$httpBackend_;
    }));
    // ReSharper restore InconsistentNaming

    it("should return weather forecast", function() {
        var response;

        $httpBackend.when("GET", "api/Weather")
            .respond(200, weatherData);

        weatherService.get().then(function(data) {
            response = data;
        });

        $httpBackend.flush();

        expect(response.data).toEqual(weatherData);
    });
});