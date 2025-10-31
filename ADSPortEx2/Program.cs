using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Create a Menu driven interface here so a user can interact with your implementations

            //I.e. while(true){
            // print to user - "Select an option"
            // "1. Add item to tree"
            // "2. Display all items... ect
            //}

            BSTree<VideoGame> videoGames = new BSTree<VideoGame>();

            Console.WriteLine("=== Retro gaming preservation project system ===");

            bool running = true;

            while (running)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Add Video Game");
                Console.WriteLine("2. Display all Video Games in InOrder");
                Console.WriteLine("3. Display all Video Games in PreOrder");
                Console.WriteLine("4. Display all Video Games in PostOrder");
                Console.WriteLine("5. Display Video Game with earliest release year");
                Console.WriteLine("6. Current Height of the tree");
                Console.WriteLine("7. Exit");
                string choice = Console.ReadLine();

                

                switch (choice)
                {
                    case "1":
                        // Code to add a video game
                        Console.WriteLine("Enter video game title:");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter video game developer:");
                        string developer = Console.ReadLine();
                        Console.WriteLine("Enter video game release year:");
                        int releaseYear;
                        while (!int.TryParse(Console.ReadLine(), out releaseYear))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid year:");
                        }

                        VideoGame videoGame = new VideoGame(title, developer, releaseYear);
                        videoGames.InsertItem(videoGame);

                        Console.WriteLine("Added new video game");
                        // Implementation goes here
                        break;
                    case "2":
                        // Code to display all video games
                        Console.WriteLine("Displaying all video games...");
                        // Implementation goes here
                        break;
                    case "7":
                        running = false;
                        Console.WriteLine("Exiting the system. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            Console.ReadLine();

        }
    }
}
