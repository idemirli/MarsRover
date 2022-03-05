using MarsRoverProblemSolution.Repository.Invoker;
using MarsRoverProblemSolution.Repository.Provider;
using MarsRoverProblemSolution.Service;
using MarsRoverProblemSolution.Service.Provider;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MarsRoverSolution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Example Data Entry (Max Points) : 4,4");
            var maxPoints = Console.ReadLine().Split(',');
            Console.WriteLine("Example data entry (Current Location) : 1,2,W");
            var currentLocation = Console.ReadLine().Split(',');
            Console.WriteLine("Example data entry (Movement) : MMLLMLML");
            var movement = Console.ReadLine();

            var services = new ServiceCollection();
            services.AddSingleton<IMarsRoverService, MarsRoverService>();
            services.AddSingleton<Invoker, ExecuteAction>();
            var _serviceProvider = services.BuildServiceProvider(true);
            var _marsRoverProblemSolutionService = _serviceProvider.GetService<IMarsRoverService>();
            var _invoker = _serviceProvider.GetService<Invoker>();

            var coordinates = _marsRoverProblemSolutionService.MoveRoverSync(maxPoints, currentLocation, movement, _invoker);
            if (coordinates != null)
                Console.WriteLine(coordinates.X + " " + coordinates.Y + " " + coordinates.Dir);
            else
                Console.WriteLine("Bad Request");

            DisposeServices(_serviceProvider);
        }

        private static void DisposeServices(ServiceProvider _serviceProvider)
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
