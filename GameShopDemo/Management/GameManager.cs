using GameShopDemo.Abstract;
using GameShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopDemo.Management
{
    public class GameManager : IgameSellService
    {
        public void Sell(User user , Game game ,Campaign campaign) // oyun için gerekli metotları aktif hale getirdik
        {
            Console.WriteLine(user.FirstName + " :İsimli User " + game.GameName + " İsimli Oyunu Satıyor" + " --> Oyun Fiyatı:"+ game.GamePrice);
            Console.WriteLine(campaign.CampaignName + " : Kampanyasından Yararlanabilirsiniz !");
        }
    }
}
