using Review.Domain;
using Review.Repositories.Abstract;

namespace Review.Repositories
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly List<WeatherForecast> Dates = new List<WeatherForecast>
        {
            new() { Date = new(2020, 01, 01), TemperatureC =  -1, Summary = Summaries[Random.Shared.Next(Summaries.Length)] },
            new() { Date = new(2020, 01, 01), TemperatureC =  2, Summary = Summaries[Random.Shared.Next(Summaries.Length)] },
            new() { Date = new(2020, 02, 01), TemperatureC =  0, Summary = Summaries[Random.Shared.Next(Summaries.Length)] },
            new() { Date = new(2020, 03, 01), TemperatureC =  5, Summary = Summaries[Random.Shared.Next(Summaries.Length)] },
            new() { Date = new(2020, 04, 01), TemperatureC =  30, Summary = Summaries[Random.Shared.Next(Summaries.Length)] },
            new() { Date = new(2020, 05, 01), TemperatureC =  -28_000, Summary = Summaries[Random.Shared.Next(Summaries.Length)] }
        };

        /// <summary>
        /// Получает прогноз погоды.
        /// </summary>
        /// <returns>Список прогнозов.</returns>
        public List<WeatherForecast> Get() {
            return Dates.ToList();
        }

        /// <summary>
        /// Получает прогноз погоды.
        /// </summary>
        public async void UpdateAsync(DateOnly date, int t, CancellationToken cancellation)
        {
            await Task.Factory.StartNew(() =>
            {
                var forecast = Dates.SingleOrDefault(d => d.Date == date);
                forecast.TemperatureC = t;
            });
        }
    }
}
