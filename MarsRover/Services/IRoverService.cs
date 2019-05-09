using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRover.Services
{
    public interface IRoverService
    {
        RoverPosition Navigate(RoverPosition start, string command);
    }
}
