using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_5_GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Id = 1;
            player.FirstName = "Ahmet";
            player.Lastname = "GÜÇKOL";
            player.NationalityId = 123456789;
            player.DateOfBirth = new DateTime(1989, 02, 27);

            PlayerManager playerManager = new PlayerManager();
            playerManager.ValidateAndSave(player);
            playerManager.DeletePlayer(player);

            CampaignManager campaignManager = new CampaignManager();

            GameManager gameManager = new GameManager();
            gameManager.SellGame(player);
            gameManager.SellGame(campaignManager);
        }
    }
}
