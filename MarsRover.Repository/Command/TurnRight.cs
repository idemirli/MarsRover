using MarsRoverProblemSolution.Data.Constants;
using MarsRoverProblemSolution.Data.Entities;

namespace MarsRoverProblemSolution.Repository.Command
{
    public class TurnRight : Provider.Command
    {
        public Coordinates Execute(Coordinates coordinates)
        {
            switch (coordinates.Dir)
            {
                case Directions.N:
                    coordinates.Dir = Directions.E;
                    break;

                case Directions.E:
                    coordinates.Dir = Directions.S;
                    break;

                case Directions.S:
                    coordinates.Dir = Directions.W;
                    break;

                case Directions.W:
                    coordinates.Dir = Directions.N;
                    break;
            }
            return coordinates;
        }
    }
}
