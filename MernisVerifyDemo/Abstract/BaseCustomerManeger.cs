using MernisVerifyDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisVerifyDemo.Abstract
{
    internal abstract class BaseCustomerManeger : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to Database! :" + customer.FirstName);
        }
    }
}
