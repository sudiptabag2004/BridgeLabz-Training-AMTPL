using System;
using System.Text.RegularExpressions;


namespace BridgelabzApp
{
    class Program
    {
        public static void Main(String[] args)
        {
            string[] str = { "3456789a", "4333439b", "dsfewfw" };

            foreach (string st in str)
            {
                if (checkstring(st))
                {
                    Console.WriteLine($"st is a valid username");
                }
                else
                {
                    Console.WriteLine($"st is not a valid username");
                }
            }
        }

        public static bool checkstring(string username)
        {
            string strRegex = @"^\d{7}\w$";
            
            Regex re = new Regex(strRegex);
            
            if(re.IsMatch(username))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
};

