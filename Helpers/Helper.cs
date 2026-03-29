using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Helpers
{
    internal static class Helper
    {
        public static bool CheckPasswordNo(string passwordNo)
        {
            if (string.IsNullOrEmpty(passwordNo) == false)
            { 
                if (passwordNo.ToArray().Length == 8)
                { 
                    return true;
                }
                

            }
            return false;
        
        }

        public static bool CheckAge(int age)
        {
            if (age < 2)
            { 
            
                return false;
            }
            return true;
        }
        public static bool CheckDestination(string d)
        {
            if (string.IsNullOrEmpty(d)==true)
            {
                return false;

            }
            return true;


        }

        public static bool CheckFullName(string f)
        {
            if (string.IsNullOrEmpty(f)==true)
            {
                return false;

            }
            return true;

        }
    }
}
