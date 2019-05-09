using MarsRover.Models;

namespace MarsRover.Services
{
    public interface IEnvironmentSerive
    {
        int MaxX { get; set; }
        int MaxY { get; set; }

        bool ValidateMove(RoverPosition position);
        bool IsInitialized();
    }
}
