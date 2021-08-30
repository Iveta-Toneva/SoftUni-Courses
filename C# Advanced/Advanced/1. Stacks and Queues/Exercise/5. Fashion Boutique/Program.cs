using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacityRack = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            int sumClothes = 0;
            int countRack = 0;
            for (int i = 0; i < clothes.Length; i++)
            {
                stack.Push(clothes[i]);
            }
            while (stack.Count>0)
            {
                int current = stack.Peek();
                if (sumClothes+current<capacityRack)
                {
                    stack.Pop();
                    sumClothes += current;
                    
                }
                else if (sumClothes+current==capacityRack)
                {
                    stack.Pop();
                    countRack++;
                    sumClothes = 0;
                }
                else
                {
                    
                    countRack++;
                    sumClothes = 0;
                }




            }
            if (sumClothes>0)
            {
                countRack++;
            }
            Console.WriteLine(countRack);
        }
    }
}
