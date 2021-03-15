using OyunDemo.Abstract;
using OyunDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunDemo.Concrete
{
    public class OrderManager : IOrderService
    {
        public void Sale(Customer customer, Game game, Campaign campaign)
        {
            Console.WriteLine("Satıldı");
        }
    }
}
