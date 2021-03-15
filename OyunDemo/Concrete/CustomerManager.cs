using OyunDemo.Abstract;
using OyunDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunDemo.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public void Add(Customer customer)
        {
            if(_customerCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Oyuncu Eklendi " + customer.FirstName + " " + customer.LastName);
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız");
            }
            
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Oyuncu Silindi " + customer.FirstName + " " + customer.LastName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Oyuncu Güncellendi " + customer.FirstName + " " + customer.LastName);
        }
    }
}
