using GameShopDemo.Abstract;
using GameShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopDemo.Management
{
    public class UserManager : IUserService //User a istenen özellikleri ekledik.
    {
        public void Delete(User user)
        {
            Console.WriteLine(user.UserId + " :Numaralı User Silindi ! ");
        }

        private IUserCheckService _userCheckService;

        public  UserManager(IUserCheckService userCheckService) //Constructor 
        {
            _userCheckService = userCheckService;
        }

        public  void Save(User user) // user için kontrol simüslasyonunu yaptık.
        {
            if (_userCheckService.CheckUserOfRealUser(user))
            {
                Console.WriteLine(user.FirstName+" :İsimli User başarıyla kaydedildi !");
            }
            else
            {
                throw new Exception("Not a valid real USER !");
            }
        }

        public void Update(User user)
        {
            Console.WriteLine(user.UserId +" :Numaralı User Güncellendi ! ");
        }
    }
}
