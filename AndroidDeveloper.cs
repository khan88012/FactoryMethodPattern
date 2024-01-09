using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class AndroidDeveloper : IEmployee
    {
        public int salary()
        {
            Console.WriteLine("Getting Android Develper Salary");
            return 50000;
        }
    }
}
