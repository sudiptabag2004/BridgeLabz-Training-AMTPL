using System;
using System.Collections;
using System.Collections.Generic;


namespace OOPS
{

    class Customer : IComparable<Customer>
    {

        public int cid { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        
        public int CompareTo(Customer other)
        {
            if (this.cid  > other.cid)
            {
                return 1;
            }
            else if (this.cid < other.cid)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    class student : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            if (x.Price > y.Price)
            {
                return 1;
            }
            else if (x.Price < y.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    
    
    class new1{

        public void Run()
        {
           

            Customer c1 = new Customer { cid = 1, Name = "raj", Price = 45 };
            Customer c2 = new Customer { cid = 2, Name = "amit", Price = 60 };
            Customer c3 = new Customer { cid = 3, Name = "sneha", Price = 75 };
            Customer c4 = new Customer { cid = 4, Name = "priya", Price = 50 };
            Customer c5 = new Customer { cid = 5, Name = "rohan", Price = 90 };
            Customer c6 = new Customer { cid = 6, Name = "meera", Price = 120 };
            Customer c7 = new Customer { cid = 7, Name = "arjun", Price = 30 };  
            
            List<Customer> li = new List<Customer>(){c1,c2,c3,c4,c5,c6,c7};

            li.Insert(4, new Customer{cid = 7, Name = "arjun", Price = 30 });
            
            student obj = new student();
            li.Sort(obj);
            foreach (Customer i in li)
                
            {
                Console.WriteLine(i.cid +" "+ i.Name +" "+ i.Price);
            }

            
        }
        


    }
}


