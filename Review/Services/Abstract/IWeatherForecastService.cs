using Review.Contracts;

namespace Review.Services.Abstract
{
    /// <summary>
    /// Сервис работы с погодой.
    /// </summary>
    public interface IWeatherForecastService
    {
        public IEnumerable<WeatherForecast> Get();

        /// <summary>
        /// Изменяет.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="temperature"></param>
        Task UpdateAsync(DateOnly id, int temperature);
    }
}
