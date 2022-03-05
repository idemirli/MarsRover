using MarsRoverProblemSolution.Data.Constants;
using MarsRoverProblemSolution.Data.Entities;

namespace MarsRoverProblemSolution.Repository.Command
{
    public class TurnLeft : Provider.Command
    {
        /// <summary>
        /// execute rotation
        /// </summary>
        public Coordinates Execute(Coordinates coordinates)
        {
            switch (coordinates.Dir)
            {
                case Directions.N:
                    coordinates.Dir = Directions.W;
                    break;

                case Directions.E:
                    coordinates.Dir = Directions.N;
                    break;

                case Directions.S:
                    coordinates.Dir = Directions.E;
                    break;

                case Directions.W:
                    coordinates.Dir = Directions.S;
                    break;
            }
            return coordinates;
        }
    }
}
