using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal class WebDevleoper : IEmployee
    {
        public int salary()
        {
            Console.WriteLine("Web Developer salary.");
            return 40000;
        }
    }
}
