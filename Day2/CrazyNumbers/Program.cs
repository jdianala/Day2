using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyMath
{
    class Program
    {
        static public double doSomething(int a, int b)
        {
            double quotient = 0;
            if(b != 0)
            {
                quotient = (double)a/b;
                return quotient;
            }
            
            else
            {
                quotient = -1;
            }

            return quotient;
        }

        static public int doSomething(int a, int b, int c )
        {
            int sum = 0;
            sum = a + b + c;
            return sum;
        }

        static public int doSomething(int a, int b, int c, int d)
        {
            int product = 0;
            product = a * b * c * d;
            return product;
        }


        static void Main(string[] args)
        {
            double quotient1 = doSomething(6, 2);
            int sum1 = doSomething(3, 3, 3);
            int product1 = doSomething(2, 2, 2, 2);

            string output1 = String.Format("Quotient = {0}", quotient1);
            string output2 = String.Format("Sum = {0}", sum1);
            string output3 = String.Format("Product = {0}", product1);        

            Console.WriteLine(output1);
            Console.WriteLine(output2);
            Console.WriteLine(output3);
            Console.ReadLine();
        }
    }
}
