using work_5_GameProjectKatmanli.Entity;
using work_5_GameProjectKatmanli.Abstract;
using work_5_GameProjectKatmanli.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace work_5_GameProjectKatmanli
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 0;
            customer.FirstName = "Ahmet";
            customer.LastName = "GÜÇKOL";
            customer.NationalityId = "12345678912";
            customer.DateOfBirth = new DateTime(1989, 02, 27);

            ICustomerService customerManager = new CustomerManager(new ValidationManager());
            customerManager.Add(customer);
            customerManager.Delete(customer);
            customerManager.Update(customer);

            Game game = new Game() { Id = 0, Name = "Call of Duty", Price = 15, Stock = 10, Producer = "VALVE" };
            IGameSalesService gameSalesManager = new GameSalesManager(customer);
            gameSalesManager.Sales(game);

            Campaign campaign = new Campaign() { Discount = 8, Name = "Beş Dolar", Id = 0 };

            IGameSalesService gameSalesManager2 = new GameSalesManager(customer, campaign);
            gameSalesManager2.CampaignSales(game);
        }
    }
}
