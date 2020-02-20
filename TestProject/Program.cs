using System;

namespace TestProject
{
    class Program
    {

        static void Main(string[] args)
        {
            // int a = 5;
            // int b = 10;
            // bool isOnline = false;

            // if (isOnline)
            //  {
            //     Console.WriteLine("Is Online");
            //   }
            //  else
            // {
            //      Console.WriteLine("Is Offline");
            // }

            /*Console.WriteLine("Enter you name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter you age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine($"{name} you are adalt");
            }
            else
            {
                Console.WriteLine($"{name} you are still child");
            }
            */
         /* int a = 0;
            while (a<10)
            {
                
                Console.WriteLine("Enter you age");
                a = Convert.ToInt32(Console.ReadLine());
            }
            */

            Console.WriteLine("Hello Player1");
            Console.WriteLine("Propose number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
          
            Console.WriteLine("Hello Player2");
            Console.WriteLine("Guess number, you have 5 attampts");
           int answer = Convert.ToInt32(Console.ReadLine());
            int countAttamps = 0;
            while (countAttamps < 5)
            {
                if (answer != number)
                {
                    Console.WriteLine("Sorry, try againe");
                    
                }
                else
                {
                    Console.WriteLine("You are win");

                }
            }
        }
    }
}
