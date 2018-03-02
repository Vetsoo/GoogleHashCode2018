using HashCode.Infra.InputReader.Services;
using System;
using HashCode.Core.Domain;
using HashCode.Core.Services;

namespace HashCode.Output
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the filename: ");
            var fileName = Console.ReadLine();

            try
            {
                var fileService = new FileService();
                var fileContents = fileService.ReadFile(fileName);
                Console.WriteLine($"Amount of rows: {fileContents.Rows}");
                Console.WriteLine($"Amount of columns: {fileContents.Columns}");
                Console.WriteLine($"Number of vehicles in fleet: {fileContents.NumberOfVehicles}");
                Console.WriteLine($"Number of rides: {fileContents.NumberOfRides}");
                Console.WriteLine($"Bonus for starting on time: {fileContents.PerRideBonusForStartingOnTime}");
                Console.WriteLine($"Number of steps in simulation: {fileContents.NumberOfStepsInSimulation}");
                Console.WriteLine();
                Console.WriteLine();
                //Console.WriteLine($"Here is your pizza:");
 
                //for (int i = 0; i < fileContents.Pizza.GetLength(0); i++)
                //{
                //    for (int j = 0; j < fileContents.Pizza.GetLength(1); j++)
                //    {
                //        Console.Write(fileContents.Pizza[i, j]);
                //    }
                //    Console.WriteLine();
                //}

                //TODO Execute algorithm
                var algorithmService = new AlgorithmService();

                var result = algorithmService.AssignRides(fileContents);

                //TODO Write correct solution to file
                fileService.WriteFile(result);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}