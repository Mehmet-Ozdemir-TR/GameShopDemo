using GameShopDemo.Abstract;
using GameShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopDemo.Management
{
    public class UserCheckManager : IUserCheckService
    {
        public bool CheckUserOfRealUser(User user) //Tc kontrolünün yapılıp doğru döndüğünü simüle ettik.
        {
            return true;
        }
    }
}
