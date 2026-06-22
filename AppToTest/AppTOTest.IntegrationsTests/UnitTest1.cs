using Microsoft.AspNetCore.Mvc.Testing;
using System.Text.Json;
using Xunit;
using Ardalis.HttpClientTestExtensions;

namespace AppTOTest.IntegrationsTests
{
    public class WeatherForecastApiGet(CustomWebApplicationFactory<Program> factory) :
        IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly HttpClient _client = factory.CreateClient();

        [Fact]
        public async Task Returns5Forecasts()
        {
            var response = await _client.GetAsync("/weatherforecast");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            var forecast = JsonSerializer.Deserialize<List<WeatherForecast>>(responseString);

            Assert.Equal(5, forecast!.Count);
        }



        [Fact]
        public async Task Returns5ForecastsSmaller()
        {
            var forecast = await _client.GetAndDeserializeAsync<List<WeatherForecast>>("/weatherforecast");

            Assert.Equal(5, forecast!.Count);
        }
    }

}
