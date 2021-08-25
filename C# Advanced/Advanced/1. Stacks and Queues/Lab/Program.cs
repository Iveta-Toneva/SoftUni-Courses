using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string command1 = Console.ReadLine();
            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();
            while (command1!="Sail")
            {
                string[] data = command1.Split("||",StringSplitOptions.RemoveEmptyEntries);
                string town = data[0];
                double population = double.Parse(data[1]);
                double gold = double.Parse(data[2]);
                if (!dict.ContainsKey(town))
                {

                    dict.Add(town, new List<double>());
                    dict[town].Add(population);

                    dict[town].Add( gold);
                }
                else
                {
                    dict[town][0] += population;
                    dict[town][1] += gold;
                }

                

                command1 = Console.ReadLine();
            }
            string command2 = Console.ReadLine();
            while (command2!="End")
            {
                string[] data = command2.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                if (data[0]=="Plunder")
                {
                    string stolentown = data[1];
                    double killedpeople = double.Parse(data[2]);
                    double stolegold = double.Parse(data[3]);
                    dict[stolentown][0] -= killedpeople;
                    dict[stolentown][1] -= stolegold;
                    Console.WriteLine($"{stolentown} plundered! {stolegold} gold stolen, {killedpeople} citizens killed.");
                    if (dict[stolentown][0]<=0||dict[stolentown][1]<=0)
                    {
                        Console.WriteLine($"{stolentown} has been wiped off the map!");
                        dict.Remove(stolentown);
                     
                    }
                   
                    
                }
                else if (data[0]=="Prosper")
                {
                    string prosTown = data[1];
                    double prosgold = double.Parse(data[2]);
                    if (prosgold<0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        command2 = Console.ReadLine();
                        continue;
                       

                    }
                    dict[prosTown][1] += prosgold;
                    Console.WriteLine($"{prosgold} gold added to the city treasury. {prosTown} now has {dict[prosTown][1]} gold.");
                }





                command2 = Console.ReadLine();
            }
            if (dict.Count==0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {dict.Count} wealthy settlements to go to:");
                foreach (var item in dict.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }

        }
    }
}
