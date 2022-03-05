using MarsRoverProblemSolution.Data.Entities;

namespace MarsRoverProblemSolution.Repository.Invoker
{
    public class ExecuteAction : Provider.Invoker
    {
        public Coordinates StartMoving(Provider.Command command, Coordinates coordinates)
        {
            return command.Execute(coordinates);
        }
    }
}
