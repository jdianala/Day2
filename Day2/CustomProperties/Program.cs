using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CustomerProperties
{

    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB;
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age cannot be less than zero.");
                    _age = 0;                    
                }
                else
                    _age = value;

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sally = new Customer
            {
                FirstName = "Sally",
                LastName = "Williams",
                DOB = new DateTime(2028, 6, 10),
                Age = 23

            };

            Debug.Assert(sally.Age == 28, "Sally is 23.");
            Console.ReadLine();

            var mike = new Customer
            {
                FirstName = "Mike",
                LastName = "Harrison",
                DOB = new DateTime(2019, 6, 10),
                Age = 10

            };

            Debug.Assert(mike.Age == 10, "Mike is 10.");
            Console.ReadLine();

        }
    }
}
