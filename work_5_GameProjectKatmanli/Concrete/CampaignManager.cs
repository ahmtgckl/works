using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_5_GameProjectKatmanli.Entity;

namespace work_5_GameProjectKatmanli.Concrete
{
    public class CampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " isimli kampanya eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            campaign.Discount = 0;
            Console.WriteLine(campaign.Name + " isimli kampanya silindi.");
        }

        public void Update(Campaign campaign, int discount)
        {
            campaign.Discount = discount;
            Console.WriteLine(campaign.Name + " isimli kampanya güncellendi.");

        }
    }
}
