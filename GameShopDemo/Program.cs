using GameShopDemo.Abstract;
using GameShopDemo.Entities;
using GameShopDemo.Management;
using System;

namespace GameShopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Users
            User user1 = new User();
            user1.UserId = 1;
            user1.NationalityId = "123456";
            user1.FirstName = "Mehmet";
            user1.LastName = "Özdemir";
            user1.DateOfBirth = new DateTime(1999, 5, 6);

            User user2 = new User();
            user2.UserId = 2;
            user2.NationalityId = "189456";
            user2.FirstName = "Ahmet";
            user2.LastName = "Kara";
            user2.DateOfBirth = new DateTime(1999, 7, 5);

            User user3 = new User();
            user3.UserId = 3;
            user3.NationalityId = "189647";
            user3.FirstName = "Mahmut";
            user3.LastName = "Çelik";
            user3.DateOfBirth = new DateTime(1999, 2, 3);

            //Campaigns

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 11;
            campaign1.CampaignName = "Kış İndirimi";
            campaign1.CampaignValue = "%20";

            Campaign campaign2 = new Campaign();
            campaign2.CampaignId = 12;
            campaign2.CampaignName = "Bahar İndirimi";
            campaign2.CampaignValue = "%25";

            Campaign campaign3 = new Campaign();
            campaign3.CampaignId = 13;
            campaign3.CampaignName = "Yaz İndirimi";
            campaign3.CampaignValue = "%50";

            //Games

            Game game = new Game();
            game.GameId = 45;
            game.GameName = "Star Wars";
            game.GamePrice = 50.0;


            IUserService userService = new UserManager(new UserCheckManager()); // User için gerekli İşlemleri çağırmak için referans aldık.
            userService.Save(user1);
            userService.Update(user2);
            userService.Delete(user3);

            Console.WriteLine("*******************************************************************");

            ICampaignService campaignService = new CampaignManager(); //  Campaign için gerekli işlemleri çağırmak için referans aldık.
            campaignService.Add(campaign2);
            campaignService.Delete(campaign3);
            campaignService.Update(campaign1);

            Console.WriteLine("*******************************************************************");

            IgameSellService gameSellService = new GameManager(); //Game için gerekli işlemleri çağırmak için referans aldık.
            gameSellService.Sell(user2, game , campaign3);

        }
    }
}
