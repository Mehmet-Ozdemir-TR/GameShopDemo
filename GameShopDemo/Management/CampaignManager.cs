using GameShopDemo.Abstract;
using GameShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopDemo.Management
{
    public class CampaignManager : ICampaignService // campaign için gerekli işlemleri yaptık.
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " :İsimli Kampanya Silindi !");
        }

        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " :İsimli kampanya eklendi !");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " :İsimli Kampanya Güncellendi !");
        }
    }
}
