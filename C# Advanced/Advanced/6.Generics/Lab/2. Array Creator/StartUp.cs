using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[]array=(ArrayCreator<int>.Create(4,44));
            Console.WriteLine(string.Join(" ",array));
        }
    }
}
