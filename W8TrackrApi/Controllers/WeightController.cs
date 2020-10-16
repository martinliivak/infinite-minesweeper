using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using W8TrackrApi.Models;

namespace W8TrackrApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeightController : ControllerBase
    {
        private static readonly double[] weights = new[]
        {
            10.0, 20.0, 56.0, 12.0
        };

        private readonly ILogger<WeightController> _logger;

        public WeightController(ILogger<WeightController> logger)
        {
            _logger = logger;
            
            _logger.LogInformation($"constructed naow {DateTime.UtcNow.ToLongTimeString()}");
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation($"get request naow {DateTime.UtcNow.ToLongTimeString()}");

            var rng = new Random();
            WeightInstance[] weightInstances = Enumerable.Range(1, 5).Select(index => new WeightInstance
            {
                Date = DateTime.Now.AddDays(index),
                Weight = weights[rng.Next(weights.Length)]
            }).ToArray();

            //return NotFound();

            return Ok(weightInstances);
        }

        [HttpPost]
        public IActionResult Post([FromBody] WeightInstance weight)
        {
            _logger.LogInformation($"post done naow {DateTime.UtcNow.ToLongTimeString()}");
            _logger.LogInformation($"post content {weight}");
            _logger.LogInformation($"post content {weight.Date}");
            _logger.LogInformation($"post content {weight.Weight}");
            
            // do stuff
            return Ok("lmao");
        }
    }
}
