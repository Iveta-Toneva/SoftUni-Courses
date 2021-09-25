using System;

namespace DefiningClasses
{
     public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Gosho";
            person.Age = 20;
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}
