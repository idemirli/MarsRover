using MarsRoverProblemSolution.Data.Entities;
using MarsRoverProblemSolution.Repository.Provider;

namespace MarsRoverProblemSolution.Service.Provider
{
    public interface IMarsRoverService
    {
        Coordinates MoveRoverSync(string[] maxPoints, string[] currentLocation, string movement, Invoker _invoker);
    }
}
