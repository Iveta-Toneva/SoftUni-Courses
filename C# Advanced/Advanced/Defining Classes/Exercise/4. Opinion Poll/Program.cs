using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string name = data[0];
                int age = int.Parse(data[1]);
                Person person = new Person(name, age);
                list.Add(person);
            }
            List<Person> filter = list.OrderBy(x => x.Name).Where(x => x.Age > 30).ToList();
            foreach (var person in filter)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }


        }
    }
}

