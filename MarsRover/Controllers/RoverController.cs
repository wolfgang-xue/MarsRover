using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarsRover.Models;
using MarsRover.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarsRover.Controllers
{
    [Produces("application/json")]
    [Route("api/Rover")]
    public class RoverController : Controller
    {
        #region Fields
        private IRoverService _roverService;
        private IEnvironmentSerive _environmentService;
        #endregion

        #region ctor
        public RoverController(IRoverService roverService, IEnvironmentSerive environmentSerive)
        {
            _roverService = roverService;
            _environmentService = environmentSerive;
        }
        #endregion

        #region API Methods
        // GET: api/Rover
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var start = new RoverPosition() { Name = "Rover1", Direction = 'N', X = 1, Y = 2 };
            string command = "LMLMLMLMM";
            // 1 3 N
            var end =_roverService.Navigate(start, command);

            start = new RoverPosition() { Name = "Rover2", Direction = 'E', X = 3, Y = 3 };
            command = "MMRMMRMRRM";
            // 5 1 E
            end = _roverService.Navigate(start, command);

            return new string[] { "value1", "value2" };
        }

        // GET: api/Rover/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Rover
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Rover/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        #endregion
    }
}
