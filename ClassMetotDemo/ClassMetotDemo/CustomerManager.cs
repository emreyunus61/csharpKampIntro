using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        
        public void customerList(Customer[] customers)
        {

            foreach (Customer i in customers)
            {
                Console.WriteLine(i.Id + " " + i.FirstName + " " + i.LastName + " " + i.Balance);
            }
        }
    }
}
