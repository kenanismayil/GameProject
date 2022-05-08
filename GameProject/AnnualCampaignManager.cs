using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class AnnualCampaignManager : ICampaignManager
    {
        public void DeleteCampaign()
        {
            Console.WriteLine("-> Kampanya Silindi!");
        }

        public void NewCampaignAdd()
        {
            Console.WriteLine("-> Kullaniciya yillik  %50 kupon tamamlandi!");
        }

        public void UpdateCampaign()
        {
            Console.WriteLine("-> Aldigi oyun minimum 50 tl olmalidir.!");
            Console.WriteLine("-> Kupon 12.12.23 23:59'a kadar gecerlidir.");
        }
    }
}
