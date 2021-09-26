using System;
using System.Linq;

namespace Tuple
{
   public class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split().ToArray();
            string firstName = data[0];
            string lastName = data[1];
            string address = data[2];
            string fullName = firstName + " " + lastName;
            Tuple<string, string> tuple = new Tuple<string, string>(fullName, address);
            
            string[] data2 = Console.ReadLine().Split().ToArray();
            string name = data2[0];
            int litters = int.Parse(data2[1]);
            Tuple<string, int> beer = new Tuple<string, int>(name,litters);
           
            string[] dataNumbers = Console.ReadLine().Split().ToArray();
            int num = int.Parse(dataNumbers[0]);
            double secondNum = double.Parse(dataNumbers[1]);
            Tuple<int, double> numbers = new Tuple<int, double>(num, secondNum);
            Console.WriteLine(tuple);
            Console.WriteLine(beer);
            Console.WriteLine(numbers);
        }
    }
}
