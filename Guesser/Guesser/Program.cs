using System;

namespace Guesser
{
    class Program
    {
        const int MaxTrials = 10;
        
        static void Main(string[] args)
        {
            
            string name = "Jeff";
            name = name.ToUpper();

            Console.WriteLine("Guess the name");
            for (int i=0; i < MaxTrials;)
            {
                string guessName = Console.ReadLine();
                guessName=guessName.ToUpper();

                i++;

                int TimesLeft = 10 - i;

                if (name == guessName)
                {
                    Console.WriteLine("Hell yeah! You got it with "+TimesLeft+" tries left");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (name != guessName && guessName.StartsWith("J"))
                {
                    Console.WriteLine("You are getting close, the name does start with j");
                    Console.WriteLine("you have " + TimesLeft + " trys left. try again,");
                }

                else
                {
                    Console.WriteLine("wroooong, you have "+ TimesLeft + " trys left. try again,");
                }

            }
            Environment.Exit(0);
        }
    }
}
