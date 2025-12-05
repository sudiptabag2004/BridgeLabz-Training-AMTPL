using System;
using System.Collections.Generic;

namespace OOPS
{
    class ErrorAge :  Exception
    {
        public ErrorAge(string message) : base(message)
        {
            
        }
        
    }

    class UnacceptedAge : Exception
    {
        public UnacceptedAge(string message) : base(message)
        {
            
        }
    }
        

    public class ExceptionExample
    {
        public void Run()
        {
            try
            {
                checkage(14);
            }
            catch (ErrorAge ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnacceptedAge ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void checkage(int age)
        {
            if (age < 0)
            {
                throw new ErrorAge("error as age is negative");
            }
            else if (age > 24)
            {
                throw new UnacceptedAge("error as age is greater than 24");
            }
            else
            {
                Console.WriteLine("Age is accepted");
            }
           
        }
    }
};

