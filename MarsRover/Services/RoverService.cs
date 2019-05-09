using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRover.Services
{
    public class RoverService : IRoverService
    {

        public RoverService()
        {

        }

        public RoverPosition Navigate(RoverPosition start, string command)
        {
            return new RoverPosition();
        }
    }
}
