using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
     public class DateModifier
    {
        public int Difference(string first, string second)
        {
            DateTime firstData = DateTime.Parse(first);
            DateTime secondData =DateTime.Parse(second);
            int difference =(int)Math.Abs((firstData - secondData).TotalDays);
            return difference;
        }


    }
}
