using OyunDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
