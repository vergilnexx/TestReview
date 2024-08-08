using Review.Domain;

namespace Review.Repositories.Abstract
{
    public interface IWeatherForecastRepository
    {
        public List<WeatherForecast> Get();

        /// <summary>
        /// Обновляет данные прогноза на конкретную дату.
        /// </summary>
        /// <param name="id">Дата.</param>
        /// <param name="temperature">Температура.</param>
        /// <param name="token">Токен отмены.</param>
        void UpdateAsync(DateOnly id, int temperature, CancellationToken token);
    }
}
