using System;

namespace TestProject
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your number");
            double number = Convert.ToDouble(Console.ReadLine());
            while (number>0)
            {
                Console.WriteLine(--number);
                
                if (number==0)
                {
                    Console.WriteLine("Boom");
                    
                   
                }
              
            }

        }
    }
}

