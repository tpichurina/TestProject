using System;

namespace TestProject
{
    class Program
    {

        static void Main(string[] args)
        {
           Console.WriteLine("Hello World!");
            
            
            Console.ReadLine();

            Student std1;

            std1 = new Student();
            Console.WriteLine(std1.age);

            Console.ReadLine();
            std1.age = 25;
            Console.WriteLine(std1.age);
            Console.ReadLine();

            Calculate(std1);
            Console.WriteLine(std1.age);
            string name = "Tanya";
            std1.SetName(name);
            std1.ShowName();
            Console.ReadLine();

            string Fname = "Tanya";
            int age = 31;
            bool progremer = true;
            Console.WriteLine($"Name: {Fname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Programmer: {progremer}");

            var message = new Student();
            var t = 1000.77;
            Console.WriteLine(t);
            Console.WriteLine(message.ToString());

           // string namem = "Tanya";
           // int age5 = 31;
            //double height = 1.7;
            //Console.WriteLine($"Name: {namem} Age {4+7}year Height {height}m");

            string namem = "Tanya";
            int age5 = 31;
            double height = 1.7;
            Console.WriteLine("Name: {0} Age {1}year Height {2}m", namem, age5, height);

            Console.WriteLine("Enter name of your cat: ");
            string catname = Console.ReadLine();
            Console.WriteLine($"You so cute {catname} ;-)");

            Console.Write("Enter name: ");
            string name1 = Console.ReadLine();

            Console.Write("Enter age: ");
            int age1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter cat age: ");
            double catage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Name: {name1}, Age: {age1}, Cat Age: {catage}");
        







        }
        static void Calculate(Student s)
        {
            s.age += 1;
        }

    }

    public class Student
    {
        public int age;
        private string name;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void ShowName()
        {
            Console.WriteLine(name);
        }

    }
}
