using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            makeTitle();
            makeMainMenu();

            Console.ReadLine();
        }

        private static void makeMainMenu()
        {
            Console.WriteLine("\n\n (S)tart new game");
            Console.WriteLine("(L)oad game");
            Console.WriteLine("(C)reate game");
            var userValue = Console.ReadLine();

            Console.WriteLine($"You chose - {userValue}");

            if (userValue == "s" || userValue == "l" || userValue == "c") 
            {
                Console.WriteLine("00");
            }
            else
            {
                Console.WriteLine("Try again");
                Console.WriteLine("\n\n (S)tart new game");
                Console.WriteLine("(L)oad game");
                Console.WriteLine("(C)reate game");
                var userValu = Console.ReadLine();
            }
        }

        private static void makeTitle()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("GAME!!!");
        }
    }
}
