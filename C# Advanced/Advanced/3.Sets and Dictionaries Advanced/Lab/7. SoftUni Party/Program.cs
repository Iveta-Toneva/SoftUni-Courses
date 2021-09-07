using System;
using System.Collections.Generic;

namespace _7._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();
            string command = Console.ReadLine();
            while (command!="PARTY")
            {
                if (char.IsDigit(command[0]))
                {
                    vip.Add(command);
                }
                else
                {
                    regular.Add(command);
                }



                command = Console.ReadLine();
            }
            string comeToParty = Console.ReadLine();
            while (comeToParty!="END")
            {
                if (char.IsDigit(comeToParty[0]))
                {
                    vip.Remove(comeToParty);
                }
                else
                {
                    regular.Remove(comeToParty);
                }
                comeToParty = Console.ReadLine();
            }
            Console.WriteLine(vip.Count+regular.Count);
            foreach (var item in vip)
            {
                Console.WriteLine(item);
            }
            foreach (var item in regular)
            {
                Console.WriteLine(item);

            }
        }
    }
}
