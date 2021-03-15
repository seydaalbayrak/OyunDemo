using OyunDemo.Abstract;
using OyunDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunDemo.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            if(customer.DateOfBirth==2000 && customer.FirstName=="Şeyda" && customer.LastName=="Albayrak" && customer.NationalityId=="123456" && customer.Id==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
