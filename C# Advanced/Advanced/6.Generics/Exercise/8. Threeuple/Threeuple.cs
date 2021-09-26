using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
   public class Threeuple<T1,T2,T3>
    {
        public Threeuple(T1 firstValue,T2 secondValue,T3 thirdValue)
        {
            this.FirstValue = firstValue;
            this.SecondValue = secondValue;
            this.ThirdValue = thirdValue;
        }
        public T1 FirstValue { get; set; }
        public T2 SecondValue { get; set; }
        public T3 ThirdValue { get; set; }
        public override string ToString()
        {
            return $"{this.FirstValue} -> {this.SecondValue} -> {this.ThirdValue}";
        }
    }
}
