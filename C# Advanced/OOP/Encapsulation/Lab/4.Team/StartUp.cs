
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
                Person person = new Person(line[0],line[1],int.Parse(line[2]),decimal.Parse(line[3]));
                people.Add(person);
              
            }
            decimal percent = decimal.Parse(Console.ReadLine());
            foreach (var person in people)
            {
                person.IncreaseSalary(percent);
                Console.WriteLine(person.ToString());
            }
            Team team = new Team("SoftUni");
            foreach (var person in people)
            {
                team.AddPlayer(person);
            }
            Console.WriteLine(team.FirstTeam.Count);
            Console.WriteLine(team.ReserveTeam.Count);
           
        }
    }
}
