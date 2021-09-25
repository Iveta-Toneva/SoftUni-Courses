using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> e = new EqualityScale<int>(5, 6);
            Console.WriteLine(e.AreEqual());
        }
    }
}
