using OyunDemo.Concrete;
using OyunDemo.Entities;
using System;

namespace OyunDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Şeyda",
                LastName = "Albayrak",
                DateOfBirth = 2000,
                NationalityId = "123456"
            };

            CustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            customerManager.Add(customer);
            customerManager.Update(customer);
            customerManager.Delete(customer);

            Game game = new Game
            {
                Id = 1,
                GameName = "VALORANT"
            };

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            Campaign campaign = new Campaign()
            {
                Id = 1,
                CampaignName = "İndirim",
                CampaignRate = 3
            };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            OrderManager orderManager = new OrderManager();
            orderManager.Sale(customer, game, campaign);


        }
    }
}
