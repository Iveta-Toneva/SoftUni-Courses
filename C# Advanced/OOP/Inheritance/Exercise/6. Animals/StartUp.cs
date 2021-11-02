using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            string type = Console.ReadLine();
            while (type!= "Beast!")
            {

                string[] animalInfo = Console.ReadLine().Split();
                string name = animalInfo[0];
                int age = int.Parse(animalInfo[1]);
                string gender = animalInfo[2];
                if (age<0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                if (type=="Cat")
                {
                    Cat cat = new Cat(name, age, gender);
                    list.Add(cat);
                }
               else  if (type == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);
                    list.Add(dog);
                }
                else if (type == "Frog")
                {
                    Frog frog = new Frog(name, age, gender);
                    list.Add(frog);
                }
                else if (type=="Kitten")
                {
                    Kitten kitten = new Kitten(name, age);
                    list.Add(kitten);
                }
                else if (type == "Tomcat")
                {
                   Tomcat tom = new Tomcat(name, age);
                    list.Add(tom);

                }






                type = Console.ReadLine();
            }
            foreach (var animal in list)
            {   
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}
