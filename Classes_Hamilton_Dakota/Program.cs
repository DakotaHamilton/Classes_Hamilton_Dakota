using System;

namespace Classes_Hamilton_Dakota
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greetings Class
            Greetings greetings = new Greetings();
            
            // Greetings Variable 
            greetings.Welcome();

            // Asked for name and user reply
            Console.WriteLine("What is your name Adventurer?");
            string userName = Console.ReadLine();

            // Hello variable
            greetings.Hello(userName);
        }
    }
}
