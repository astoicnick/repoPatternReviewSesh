using ClassLibrary;
using System;

namespace ConsoleFrontEnd
{
    class ProgramUI
    {
        public void Run()
        {
            bool isRunning = true;
            DeveloperRepository devRepo = new DeveloperRepository();
            TeamRepository teamRepo = new TeamRepository();
            while (isRunning)
            {
                Console.WriteLine("Hey! What would you like to do?\n" +
                    "1. Add Developer\n" +
                    "2. Add Team\n" +
                    "3. See Developers\n" +
                    "4. See Teams");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("What is the name of the developer?");
                        string devName = Console.ReadLine();
                        devRepo.CreateDeveloper(new Developer(1, devName));
                        break;
                    case "2":
                        break;
                    case "3":
                        foreach (Developer developer in devRepo.GetAllDevelopers())
                        {
                            Console.WriteLine($"ID: {developer.DeveloperID} Name: {developer.Name}");
                        }
                        break;
                    case "4":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}