using System;

namespace DefiningClasses
{
     public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Ivan";
            person.Age = 15;
            Person gosho= new Person("Gosho", 20);
            Person stamat = new Person(15);
            stamat.Name = "Stamat";
            
        }
    }
}
