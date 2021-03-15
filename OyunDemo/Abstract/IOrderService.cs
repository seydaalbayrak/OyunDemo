using OyunDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunDemo.Abstract
{
   public interface IOrderService
    {
        void Sale(Customer customer, Game game, Campaign campaign);
    }
}
