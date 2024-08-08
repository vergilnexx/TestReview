using Microsoft.AspNetCore.Mvc;
using Review.Contracts;
using Review.Services.Abstract;

namespace Review.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IWeatherForecastService _service;

        public WeatherForecastController(IWeatherForecastService service)
        {
            _service = service;
        }

        [HttpPost]
        public IEnumerable<WeatherForecast> Get()
        {
            return _service.Get();
        }

        /// <summary>
        /// Изменет температуру
        /// </summary>
        /// <param name="temperature"></param>
        /// <returns></returns>
        [HttpDelete("update/{temperature}")]
        public async Task UpdateAsync([FromBody] DateOnly id, [FromRoute] int temperature, CancellationToken cancellationToken)
        {
            await _service.UpdateAsync(id, temperature);
        }
    }
}
