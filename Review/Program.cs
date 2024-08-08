using Review.Repositories;
using Review.Repositories.Abstract;
using Review.Services;
using Review.Services.Abstract;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();
builder.Services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();
