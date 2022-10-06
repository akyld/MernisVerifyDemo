using MernisVerifyDemo.Abstract;
using MernisVerifyDemo.Concrete;
using MernisVerifyDemo.Entities;

BaseCustomerManeger customerManeger = new StarbucksCustomerManeger(new CustomerCheckManeger());
Customer customer = new Customer();
customer.DateOfBirth = new DateTime(2000, 10, 7);
customer.FirstName = "Kaan";
customer.LastName = "Yıldırım";
customer.NationalityId = 21605183646;


customerManeger.Save(customer);
