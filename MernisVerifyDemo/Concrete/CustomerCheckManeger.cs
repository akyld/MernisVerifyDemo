using MernisServiceReference;
using MernisVerifyDemo.Abstract;
using MernisVerifyDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisVerifyDemo.Concrete
{
    internal class CustomerCheckManeger : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    
    
    }
}
