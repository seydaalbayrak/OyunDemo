using OyunDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunDemo.Entities
{
   public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
