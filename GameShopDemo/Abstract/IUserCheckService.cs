using GameShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopDemo.Abstract
{
    public interface IUserCheckService //Kullanıcı kontrolü yaptığımız kısım için interface oluşturdum.
    {
        bool CheckUserOfRealUser(User user );
    }
}
