using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNumbers
{
    class AddNumbers
    {
        static public int Add(int x, int y)
        {
            int sum = x + y;            
            return sum;

        }

       static public int Add(params int[] listOfNums)
        {
            int sum = 0;
            foreach (int i in listOfNums)
            {
                sum += i;
            }

            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
         
            int sum1 = AddNumbers.Add(1, 10, 5);
            int sum2 = AddNumbers.Add(3, 2);
            string output1 = String.Format("SUM = {0}", sum1);
            string output2 = String.Format("SUM = {0}", sum2);
            Console.WriteLine(output1);
            Console.WriteLine(output2);
            Console.ReadLine();

        }
    }
}
