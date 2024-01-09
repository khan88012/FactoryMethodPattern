using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class EmployeeFactory
    {
        public static IEmployee? GetEmployee(string empType)
        {
            if(empType.Trim().ToLower().Equals("android developer"))
            {
                return new AndroidDeveloper();
            }
            else if(empType.Trim().ToLower().Equals("web developer"))
            {
                return new WebDevleoper();
            }
            else
            {
                return null;
            }
        }
    }
}
