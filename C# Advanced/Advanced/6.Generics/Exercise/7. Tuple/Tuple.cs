using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
   public class Tuple<item1,item2>
    {
        public Tuple(item1 item,item2 item2)
        {
            this.Value = item;
            this.Value2 = item2;
        }
        public item1 Value { get; set; }
        public item2 Value2 { get; set; }
        public override string ToString()
        {
            return $"{this.Value} -> {this.Value2}";
        }
    }
}
