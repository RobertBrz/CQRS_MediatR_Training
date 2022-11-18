using MediatR;

namespace CQRS_MediaTR.Query
{
    public class GetWeatherQueryHandler : IRequestHandler<GetWeatherQuery, List<WeatherForecast>>
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public async Task<List<WeatherForecast>> Handle(GetWeatherQuery request, CancellationToken cancellationToken)
        {
            return await GetWeather();
        }

        public async Task<List<WeatherForecast>> GetWeather()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
              .ToList();
        }
    }
}
