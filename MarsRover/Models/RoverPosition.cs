using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class RoverPosition
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public char Direction { get; set; }
    }
}
