using System;

namespace StringReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            var myString = "123";
            Console.WriteLine("substring: " + myString.Substring(1) + " str[0]: " + myString[0] + " original string: " + myString);
            Console.ReadLine();
        }
    }

    public class StringReverser
    {
        public string ReverseString(string stringToReverse)
        {
            var inputCharArray = stringToReverse.ToCharArray();
            var resultCharArray = new char[inputCharArray.Length];

            int j = inputCharArray.Length;

            for (int i = 0; i < inputCharArray.Length; i++)
            {
                resultCharArray[i] = inputCharArray[j-1];
                j--;
            }

            return new String(resultCharArray);
        }

        public void SwapStrings(ref string firstString, ref string secondString)
        {
            string tempString;

            tempString = firstString;
            firstString = secondString;
            secondString = tempString;
        }

        public string stringReverseString3b(string str)
        {
            char[] chars = new char[str.Length];
            for (int i = 0, j = str.Length - 1; i <= j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }
            return new string(chars);
        }
        
    }

}
