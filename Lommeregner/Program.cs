using System;

namespace Lommeregner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the greatest calculator. Please only write small numbers :)");
            Console.WriteLine("Write a number");
            string number1 = Console.ReadLine();

            Console.WriteLine("Write a number");
            string number2 = Console.ReadLine();
          
            int number3 = Int32.Parse(number1);
            int number4 = Int32.Parse(number2);

            if (number3 == number4)
            {
                Console.WriteLine((number4 + number3) * 3);
            }
            if (number3 != number4)
            {
                Console.WriteLine(number4 + number3);
            }


            /*
            if (number3 == 1 && number4 == 1)
            {
                Console.WriteLine("4");
                Console.ReadLine();
            }
            if (number3 == 2 && number4 == 1)
            {
                Console.WriteLine("3");
                Console.ReadLine();
            }
            if (number3 == 1 && number4 == 2)
            {
                Console.WriteLine("3");
                Console.ReadLine();
            }
            if (number3 == 2 && number4 == 2)
            {
                Console.WriteLine("16");
                Console.ReadLine();
            }
             if (number3 == 3 && number4 == 2)
            {
                Console.WriteLine("5");
                Console.ReadLine();
            }
            if (number3 == 2 && number4 == 3)
            {
                Console.WriteLine("5");
                Console.ReadLine();
            }
            if (number3 == 3 && number4 == 3)
            {
                Console.WriteLine("18");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("The numbers is too big, try again");
            }

        */




        }
    }
}
