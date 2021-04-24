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
            string userValue;
            bool inptvaled;
            NewMethod(out userValue, out inptvaled);

            Console.WriteLine($"You chose - {userValue}");
            while (!inptvaled)
            {
                if (userValue == "s" || userValue == "l" || userValue == "c")
                {
                    Console.WriteLine("00");
                    if (userValue == "s")
                    {
                        startGame();
                    }
                    else if (userValue == "c")
                    {
                        createChrater();
                    }
                    else if (userValue == "l")
                    {
                        loadGame();
                    }

                    inptvaled = true;
                }
                else
                {

                    Console.WriteLine("Try again");
                    mainMenuOptions();
                    userValue = Console.ReadLine();
                }
            }

        }

        private static void mainMenuOptions()
        {
            Console.WriteLine("\n\n (S)tart new game");
            Console.WriteLine("(L)oad game");
            Console.WriteLine("(C)reate game");
        }

        private static void NewMethod(out string userValue, out bool inptvaled)
        {
            mainMenuOptions();
            userValue = Console.ReadLine();
            inptvaled = false;
        }

        private static void loadGame()
        {
            
        }

        private static void makeTitle()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("GAME!!!");
        }

        private static void startGame() 
        {
            Console.WriteLine("you started a game");

        }
        private static void createChrater()
        {
            Console.WriteLine("you are creating a chrater");
        }
    }
}
