using Review.Contracts;
using Review.Repositories.Abstract;
using Review.Services.Abstract;

namespace Review.Services
{
    /// <inheritdoc/>

    public class WeatherForecastService : IWeatherForecastService
    {
        public IServiceProvider Provider { get; }

        public WeatherForecastService(IServiceProvider provider) 
        {
            Provider = provider;
        }

        public IEnumerable<WeatherForecast> Get()
        {
            var repository = Provider.GetRequiredService<IWeatherForecastRepository>();

            var data = repository.Get() ?? [];

            var result = new List<WeatherForecast>();
            foreach (var item in data)
            {
                var forecast = new WeatherForecast(item.Date, item.TemperatureC, item.Summary);
                result.Add(forecast);
            }

            return result;
        }

        /// <inheritdoc/>
        public Task UpdateAsync(DateOnly id, int temperature)
        {
            var repository = Provider.GetRequiredService<IWeatherForecastRepository>();

            var source = new CancellationTokenSource();
            repository.UpdateAsync(id, temperature, source.Token);

            return Task.CompletedTask;
        }
    }
}
