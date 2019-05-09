using MarsRover.Models;

namespace MarsRover.Services
{
    public class EnvironmentSerive : IEnvironmentSerive
    {
        #region Properties
        public int MinX { get; set; }
        public int MinY { get; set; }
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        #endregion

        #region ctor
        public EnvironmentSerive()
        {
            MinX = MinY = 0;
            MaxX = MaxY = 0;
        }
        #endregion

        public bool ValidateMove(RoverPosition position)
        {
            if(position.X<MinX || position.X>MaxX)
            {
                return false;
            }

            if (position.Y < MinY || position.Y > MaxY)
            {
                return false;
            }

            return true;
        }

        public bool IsInitialized()
        {
            if(MaxX<=0 | MaxY<=0)
            {
                return false;
            }

            return true;
        }
    }
}
