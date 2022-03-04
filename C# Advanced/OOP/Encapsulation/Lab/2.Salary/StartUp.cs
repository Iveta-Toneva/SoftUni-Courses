
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
  public  class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                Person person = new Person(line[0],line[1],int.Parse(line[2]));
                people.Add(person);
              
            }
           var sortedPeople = people.OrderBy(x => x.FirstName).ThenBy(x => x.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine,sortedPeople));
        }
    }
}
