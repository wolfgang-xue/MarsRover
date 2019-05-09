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
            char[] actions = command.ToCharArray();

            for(var i = 0; i< actions.Length; i++)
            {
                switch(actions[i])
                {
                    case 'L':
                        start = TurnLeft(start);
                        break;
                    case 'R':
                        start = TurnRight(start);
                        break;
                    case 'M':
                        start = Move(start);
                        break;
                    default:
                        break;
                }
            }


            return start;
        }


        private RoverPosition Move(RoverPosition start)
        {
            switch (start.Direction)
            {
                case 'E':
                    start.X++;
                    break;
                case 'S':
                    start.Y--;
                    break;
                case 'W':
                    start.X--;
                    break;
                case 'N':
                    start.Y++;
                    break;
                default:
                    break;
            }
            return start;
        }

        private RoverPosition TurnLeft(RoverPosition start)
        {
            switch (start.Direction)
            {
                case 'E':
                    start.Direction = 'N';
                    break;
                case 'S':
                    start.Direction = 'E';
                    break;
                case 'W':
                    start.Direction = 'S';
                    break;
                case 'N':
                    start.Direction = 'W';
                    break;
                default:
                    break;
            }

            return start;
        }

        private RoverPosition TurnRight(RoverPosition start)
        {
            switch (start.Direction)
            {
                case 'E':
                    start.Direction = 'S';
                    break;
                case 'S':
                    start.Direction = 'W';
                    break;
                case 'W':
                    start.Direction = 'N';
                    break;
                case 'N':
                    start.Direction = 'E';
                    break;
                default:
                    break;
            }
            return start;
        }

    }
}
