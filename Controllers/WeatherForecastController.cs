using System.Globalization;
using System.Numerics;
using Microsoft.AspNetCore.Mvc;

namespace tcc.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        BigInteger number = 3000;
        var initialTime = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);

        var value = Fibonacci(1, 1, 1, number);

        var finalTime = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);

        string tempo = initialTime + " to " + finalTime;
        Console.WriteLine("Fibonacci Calc In - " + initialTime);
        Console.WriteLine("Fibonacci Calc Out - " + finalTime);

        return Enumerable.Range(1, 1).Select(index => new WeatherForecast
        {
            tempo = tempo,
            fib = value
        })
        .ToArray();
    }

    private BigInteger Fibonacci(BigInteger a, BigInteger b, BigInteger counter, BigInteger number)
    {
        //Console.WriteLine(counter + " -> " + a);
        if (counter < number) 
            Fibonacci(b, a+b, counter+1, number);
        else
            Console.WriteLine("Fibonacci: " + a);

        return a;
    }
}
