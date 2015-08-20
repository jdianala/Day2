using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] words = text.Split(' ');
            //Array.Reverse(words);
            //text = String.Join(" ", words);

            Console.WriteLine("Write a sentence.");
            var myString = Console.ReadLine().Trim();
            string[] words = myString.Split(' ');
            Array.Reverse(words);
            myString = String.Join(" ", words);             

            Console.WriteLine("Reverse: " + myString);
            Console.ReadLine();

        }
    }
}
