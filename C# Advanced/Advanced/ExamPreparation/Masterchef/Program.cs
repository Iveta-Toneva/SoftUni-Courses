using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondtLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> ingredients = new Queue<int>(firstLine);
            Stack<int> freshness = new Stack<int>(secondtLine);
            int sauce = 150;
            int counterSauce=0;
            int salad = 250;
            int counterSalad = 0;
            int cake = 300;
            int counterCake = 0;
            int lobster = 400;
            int counterLobster = 0;
            while (ingredients.Count>0&&freshness.Count>0)
            {
                int currentIngredient = ingredients.Peek();
                int currenFreshness = freshness.Peek();
                if (currentIngredient==0)
                {
                   
                   ingredients.Dequeue();
                    continue;
                }
                else
                {
                    int result = currentIngredient * currenFreshness;
                    if (result==sauce)
                    {
                       
                        counterSauce++;
                        ingredients.Dequeue();
                        freshness.Pop();
                       
                    }
                    else if (result==cake)
                    {
                       
                        counterCake++;
                        ingredients.Dequeue();
                        freshness.Pop();
                       

                    }
                    else if (result==lobster)
                    {
                        counterLobster++;
                        ingredients.Dequeue();
                        freshness.Pop();
                       
                    }
                    else if (result==salad)
                    {
                        counterSalad++;
                        ingredients.Dequeue();
                        freshness.Pop();
                      
                    }
                    else
                    {
                        freshness.Pop();
                        ingredients.Dequeue();
                        ingredients.Enqueue(currentIngredient+5);

                    }

                }
            }
            if (counterCake>=1&&counterLobster>=1&&counterSauce>=1&&counterSalad>=1)
            {
                Console.WriteLine($"Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine($"You were voted off. Better luck next year.");
            }
            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }
            if (counterCake >= 1)
            {
                Console.WriteLine($"# Chocolate cake --> {counterCake}");
            }
            if (counterSauce >= 1)
            {
                Console.WriteLine($"# Dipping sauce --> {counterSauce}");
            }
            if (counterSalad >= 1)
            {
                Console.WriteLine($"# Green salad --> {counterSalad}");
            }
            if (counterLobster >= 1)
            {
                Console.WriteLine($"# Lobster --> {counterLobster}");
            }
            
           
          
        }
    }
}
