using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_5_GameProject
{
    internal class GameManager
    {
        public void SellGame(Player player)
        {
            Console.WriteLine("Oyun satıldı: " + player.FirstName + " " + player.Lastname);
        }

        public void SellGame(CampaignManager campaignManager)
        {

            campaignManager.NewCampaign();
        }
    }
}
