using MernisVerifyDemo.Abstract;
using MernisVerifyDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisVerifyDemo.Concrete
{
    internal class StarbucksCustomerManeger : BaseCustomerManeger
    {
        ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManeger(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            
            throw new Exception("Not a valid person");
            
            
            
            
        }

        private void CheckIfRealPerson(Customer customer)
        {
            
        }

        
    }
}
