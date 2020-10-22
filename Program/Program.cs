using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int welcome = 1;
            
            if (welcome == 1){
            System.Console.WriteLine("Welcome to your shop, you will now try to get the best value of your and others books.");
            System.Console.WriteLine("You have 25 gold in your pocket, and might get a potensial costumer soon");
            Console.ReadLine();
            welcome = 0;
            }

            System.Console.WriteLine("Hello i wold like to sell a " + spooky() + "book");

            
           
        }
    }
}
