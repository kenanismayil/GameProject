using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class MonthlyCampaignManager : ICampaignManager
    {
        public void DeleteCampaign()
        {
            Console.WriteLine("-> Kampanya Silindi!");
        }

        public void NewCampaignAdd()
        {
            Console.WriteLine("-> Kullaniciya aylik %20 kupon tanimlandi!");
        }

        public void UpdateCampaign()
        {
            Console.WriteLine("-> Aldigi oyun minimum 50 tl olmalidir.!");
            Console.WriteLine("-> Kupon 12.12.23 23:59'a kadar gecerlidir.");
        }
    }
}
