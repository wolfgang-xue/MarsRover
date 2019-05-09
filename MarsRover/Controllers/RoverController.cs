using System.Collections.Generic;
using MarsRover.Models;
using MarsRover.Services;
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
        // Quick Test
        [HttpGet]
        public IEnumerable<RoverPosition> Get()
        {
            // Initialize the environment
            _environmentService.MaxX = 5;
            _environmentService.MaxY = 5;

            // Test1
            var start = new RoverPosition() { Name = "Rover1", Direction = 'N', X = 1, Y = 2 };
            string command = "LMLMLMLMM";
            // 1 3 N
            var end1 =_roverService.Navigate(start, command);
            // Test2
            start = new RoverPosition() { Name = "Rover2", Direction = 'E', X = 3, Y = 3 };
            command = "MMRMMRMRRM";
            // 5 1 E
            var end2 = _roverService.Navigate(start, command);

            return new RoverPosition[] { end1, end2 };
        }
        
        // Enquiry the end position
        [HttpPost]
        public RoverPosition Post([FromBody]RoverPositionVm start)
        {
            RoverPosition end = null;

            if (_environmentService.IsInitialized())
            {
                end = _roverService.Navigate(start.Position, start.Command);
            }

            return end;
        }
        
        // Set the max boundary
        [HttpPut]
        public void Put([FromBody]RoverPosition max)
        {
            _environmentService.MaxX = max.X;
            _environmentService.MaxY = max.Y;
        }

        #endregion
    }
}
