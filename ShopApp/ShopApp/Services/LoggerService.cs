using System;
using ShopApp.Models;
using ShopApp.Services.Abstractions;

namespace ShopApp.Services
{
    public class LoggerService : ILoggerService
    {
        public void SuccessfulTemplate(Animals[] animals)
        {
            for (var i = 0; i < animals.Length; i++)
            {
                if (animals[i] == null)
                {
                    break;
                }

                Console.WriteLine($"{i + 1}. '{animals[i].Name}', weight: {animals[i].Weight}");
            }

            Console.WriteLine();
        }

        public void SuccessfulBuildLog(Animals[] animals, int numberOfAnimals)
        {
            Console.WriteLine("The animals were transferred to the reserve successfully! You can see the list of included creatures below:");
            Console.WriteLine();
            SuccessfulTemplate(animals);
            Console.WriteLine($"Total number of different animals: {numberOfAnimals}");
            Console.WriteLine();
        }

        public void SuccessfulSortLog(Animals[] animals)
        {
            Console.WriteLine("The animals were sorted successfully. Results are below:");
            Console.WriteLine();
            SuccessfulTemplate(animals);
        }

        public void SuccessfulSearchLog(Animals[] animals)
        {
            Console.WriteLine("Your query was processed successfully. Results are below:");
            Console.WriteLine();
            SuccessfulTemplate(animals);
        }
    }
}
