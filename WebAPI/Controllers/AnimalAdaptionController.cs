using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalAdaptionController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<AnimalAdaptionController> _logger;

        public AnimalAdaptionController(ILogger<AnimalAdaptionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<AnimalAdaption> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new AnimalAdaption
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
