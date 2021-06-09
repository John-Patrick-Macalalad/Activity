using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.Clear();

            Console.WriteLine("|==========================================|");
            Console.WriteLine("|                 LOG IN                   |");
            Console.WriteLine("|==========================================|");

            string user, pass;
            Console.WriteLine("Enter your username: ");
            user = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter you password: ");
            pass = Convert.ToString(Console.ReadLine());
            if (user == "admin" && pass == "12345")
            {
                Console.WriteLine("|==========================================|");
                Console.WriteLine("|           Logged in Succesfully          |");
                Console.WriteLine("|==========================================|");
                Console.WriteLine("");
                Console.WriteLine("Press Enter again to go the Menu. ");

                Menu.MainMenu();
            }
            else
            {
                Console.WriteLine("Log in failed");
                Console.ReadLine();
                goto Start;
            }

            Console.ReadLine();
        }
    }
}
