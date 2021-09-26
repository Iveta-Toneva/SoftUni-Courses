using System;
using System.Linq;

namespace Threeuple
{
     public class Program
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split().ToArray();
            string fullName = personInfo[0] + " " + personInfo[1];
            string address = personInfo[2];
            string town = personInfo[3];
            Threeuple<string, string, string> person = new Threeuple<string, string, string>(fullName, address, town);
           
            string[] data = Console.ReadLine().Split().ToArray();
            string name = data[0];
            int litters = int.Parse(data[1]);
            string drunkOrNot = data[2];
            bool isDrunk = false;
            if (drunkOrNot == "drunk")
            {
                isDrunk = true;
            }
            Threeuple<string, int, bool> beer = new Threeuple<string, int, bool>(name, litters, isDrunk);
            string[] ballance = Console.ReadLine().Split().ToArray();
            string personName = ballance[0];
            double money = double.Parse(ballance[1]);
            string bankName = ballance[2];

            Threeuple<string, double, string> bank = new Threeuple<string, double, string>(personName, money, bankName);
            Console.WriteLine(person);
            Console.WriteLine(beer);
            Console.WriteLine(bank);
        }
    }
}
