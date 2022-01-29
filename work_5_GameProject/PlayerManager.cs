using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_5_GameProject
{
    internal class PlayerManager
    {
        public void ValidateAndSave(Player player)
        {
            if (CheckIfRealPerson(player))
            {
                Console.WriteLine("Oyuncu doğrulandı!");
            }
            else
            {
                throw new Exception("Geçerli Bir Kişi Değil!");
            }
        }


        private bool CheckIfRealPerson(Player player)
        {   /*
            MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(player.NationalityId, player.Name.ToUpper(), player.Surname.ToUpper(), player.DateOfBirth.Date);
            */
            return true;
        }

        public void RegisterToSystem(Player Player)
        {
            Console.WriteLine("Başarıyla Kaydedildi.");
        }

        public void UpdatePlayerInfo(Player player)
        {
            Console.WriteLine("Oyuncu Bilgileri Güncellendi!");
        }

        public void DeletePlayer(Player player)
        {
            Console.WriteLine("Oyuncu Silindi!");
        }
    }
}
