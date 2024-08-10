using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class CampaignManager: ICampaignService
    {
        public void Add(Game game, Campaign campaign)
        {
            Console.WriteLine(" Yeni Kampanya yaratıldı: " + game.Name + " " + campaign.Name);
        }

        public void Delete(Game game, Campaign campaign)
        {
            Console.WriteLine(" Seçilen Kampanya silindi: " + game.Name + " " + campaign.Name);
        }

        public void Update(Game game, Campaign campaign)
        {
            Console.WriteLine(" Seçilen Kampanya güncellendi: " + game.Name + " " + campaign.Name);
        }
    }
}
