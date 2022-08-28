using System;
using System.Net.NetworkInformation;

namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {   
            return dateTime.AddTicks((long)Math.Pow(10, 14) * 100);            
        }
    }
}
