namespace Review.Domain
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        /// <summary>
        /// �����������.
        /// </summary>
        public int TemperatureC { get; set; }

        public string? Summary { get; set; }
    }
}
