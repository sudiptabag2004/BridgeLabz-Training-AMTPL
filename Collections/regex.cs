using System;
using System.Text.RegularExpressions; 
namespace Collections
{
    public class Regex1
    {
        public static void Main()
        {
            string pattern = @"^[A-Z]{3}@[1-9]{3}-[a-z]{5}$";
            string passwd = Console.ReadLine();
            bool res = Regex.IsMatch(passwd, pattern);
            Console.WriteLine(res);
            
        }
        
    }
  
};

