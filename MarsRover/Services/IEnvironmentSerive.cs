using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRover.Services
{
    interface IEnvironmentSerive
    {
        int MaxX { get; set; }
        int MaxY { get; set; }

        bool ValidateMove(RoverPosition position);
    }
}
