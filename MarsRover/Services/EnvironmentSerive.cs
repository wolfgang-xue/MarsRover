using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRover.Services
{
    public class EnvironmentSerive : IEnvironmentSerive
    {
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public bool ValidateMove(RoverPosition position)
        {
            return true;
        }
    }
}
