using Microsoft.AspNetCore.Http;
using MontyHallProblem.Models;
using System;

namespace MontyHallProblem.Services
{
    public class MontyHallService
    {
        // Method to run a simulation of the Monty Hall problem.
        public SimulationResult RunSimulation(int numberOfGames, bool switchDoor)
        {
            int winsWhenChanged = 0;
            int winsWhenStayed = 0;

            Random random = new Random();  // Random number generator for door and winning door selection

            for (int i = 0; i < numberOfGames; i++)
            {
                int winningDoor = random.Next(3);  // Randomly choose the winning door (0, 1, or 2)
                int chosenDoor = random.Next(3);   // // Randomly choose the contestant's initial door choice (0, 1, or 2)

                if (switchDoor)
                {
                    if (chosenDoor != winningDoor)
                    {
                        winsWhenChanged++;
                    }
                }
                else
                {
                    if (chosenDoor == winningDoor)
                    {
                        winsWhenStayed++;
                    }
                }
            }


            // Return a SimulationResult object with the simulation results
            return new SimulationResult
            {
                TotalGames = numberOfGames,
                WinsWhenChanged = winsWhenChanged,
                WinsWhenStayed = winsWhenStayed
            };
        }
    }
}
