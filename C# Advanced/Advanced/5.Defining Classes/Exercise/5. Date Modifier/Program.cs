using System;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            DateModifier date = new DateModifier();
            Console.WriteLine(date.Difference(first, second));
        }
    }
}
