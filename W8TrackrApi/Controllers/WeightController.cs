using System;
using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<WeightInstance> Get()
        {
            _logger.LogInformation($"get request naow {DateTime.UtcNow.ToLongTimeString()}");

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeightInstance
            {
                Date = DateTime.Now.AddDays(index),
                Weight = weights[rng.Next(weights.Length)]
            }).ToArray();
        }

        [HttpPost("{weight}")]
        public void Post(float weight)
        {
            _logger.LogInformation($"post done naow {DateTime.UtcNow.ToLongTimeString()}");
            _logger.LogInformation($"post content {weight}");
            
            // do stuff
        }
    }
}
