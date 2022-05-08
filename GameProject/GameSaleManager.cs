using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GameSaleManager
    {
        //Oyunu Alma
        public void BuyGame(Gamer gamer, Game game, ICampaignManager campaign)
        {
            Console.WriteLine($"<{gamer.Username}> adli kullanici <{game.GameName}> oyununu aldi.");
            campaign.NewCampaignAdd();
            campaign.UpdateCampaign();

        }

        //Geri Iade 
        public void PayBack(Gamer gamer, Game game)
        {
            Console.WriteLine($"<{gamer.Username}> adli kullanici <{game.GameName}> oyununu geri iade etti.");
        }     
    }
}
