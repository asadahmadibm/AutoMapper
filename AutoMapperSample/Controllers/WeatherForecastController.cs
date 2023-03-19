using AutoMapper;
using AutoMapperSample.DTO;
using AutoMapperSample.Entity;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        private readonly IMapper _mapper;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { id = 1, Name = "name1" });
            employees.Add(new Employee() { id = 2, Name = "name2" });
            employees.Add(new Employee() { id = 3, Name = "name3" });

           var x =_mapper.Map<List<EmployDTO>>(employees);



            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}