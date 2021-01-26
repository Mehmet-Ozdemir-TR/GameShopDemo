using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopDemo.Entities
{
    //Sistemde mevcut olan kampanyalar ve özellikleri.
    public class Campaign 
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string CampaignValue { get; set; }
    }
}
