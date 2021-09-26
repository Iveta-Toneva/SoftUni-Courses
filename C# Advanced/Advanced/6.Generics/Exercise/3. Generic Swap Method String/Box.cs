using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExcercises
{
    public class Box<T>
    {
        public List<T> Values { get; set; } = new List<T>();
        public Box(List<T>values)
        {
            this.Values = values;
        }
      
        public  void SwapElement(int firstIndex,int secondIndex)
        {
            T temp = this.Values[firstIndex];
            this.Values[firstIndex] = this.Values[secondIndex];
            this.Values[secondIndex] = temp;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Values)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }
            return sb.ToString().TrimEnd();
           
        }
    }
}
