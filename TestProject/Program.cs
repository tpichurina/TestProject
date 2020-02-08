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
