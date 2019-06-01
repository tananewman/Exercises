using Newtonsoft.Json;
using System;
using System.Net;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FindMinAndMaxInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new TheCoolestArrayEver();
            array.FindMinimumAndMaxValues();

            Console.ReadLine();
        }

    }
    
    public class TheCoolestArrayEver
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 8, 111, 0, -111, 44, 33, 56, -100000000, 500000000 };

        public void FindMinimumAndMaxValues()
        {
            int minimumValue = array[0], maximumValue = array[0], currentValue;

            for (int i = 0; i < array.Length; i++)
            {
                currentValue = array[i];

                if (currentValue < minimumValue)
                {
                    minimumValue = currentValue;
                }

                if (currentValue > maximumValue)
                {
                    maximumValue = currentValue;
                }
            }

            Console.WriteLine($"The minimum value is { minimumValue }.");
            Console.WriteLine($"The maximum value is { maximumValue }.");
        }
    }
}


//The minimum value should be -111.  The max should be 111.