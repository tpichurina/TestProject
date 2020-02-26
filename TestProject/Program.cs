using System;

namespace TestProject
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your text");
            string text;
            int number = 2;
            do
            {
                text = Console.ReadLine();
                if (text != "stop")
                {
                    Console.WriteLine(text + number);
                    number+=2;
                }
            }
            while (text != "stop");






        }
    }
}

