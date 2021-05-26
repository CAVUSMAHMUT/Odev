using Odev.Abstract;
using Odev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev.Concrete
{
    public class CampaingManager : ICampaignService
    {
        public void Add(Campaings campaing)
        {
            Console.WriteLine(campaing.CampaignName + " kampanyası eklendi.");
            Console.WriteLine("Kampanya İndirimi : %" + campaing.CampaignDiscount);
        }

        public void Delete(Campaings campaing)
        {
            Console.WriteLine(campaing.CampaignName + "kampanya kaldırıldı.");
        }

        public void Update(Campaings campaing)
        {
            Console.WriteLine(campaing.CampaignName + " kampanya güncellendi.");
            Console.WriteLine("Güncel Kampanya indirimi : %" + campaing.CampaignDiscount);
        }
    }
}
