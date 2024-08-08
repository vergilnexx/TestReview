namespace Review.Contracts
{
    /// <param name="Date"></param>
    /// <param name="TemperatureC"> Температура. </param>
    /// <param name="Summary"></param>
    public record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
