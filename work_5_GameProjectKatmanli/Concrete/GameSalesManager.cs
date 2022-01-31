using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_5_GameProjectKatmanli.Entity;

namespace work_5_GameProjectKatmanli.Concrete
{
    public class GameSalesManager
    {
        private Customer _customer;
        private Campaign _campaign;
        public GameSalesManager(Customer customer, Campaign campaign)
        {
            _customer = customer;
            _campaign = campaign;
        }
        public GameSalesManager(Customer customer)
        {
            _customer = customer;
        }


        public void CampaignSales(Game game)
        {
            Console.WriteLine(_customer.FirstName + " isimli oyuncu " + game.Name + " oyununu kampanyadan yararlanarak " + (game.Price - _campaign.Discount) + " dolara satın aldı.");
        }

        public void Sales(Game game)
        {
            Console.WriteLine(_customer.FirstName + " isimli oyuncu " + game.Name + " oyununu " + game.Price + " dolara satın aldı.");
        }
    }
}
