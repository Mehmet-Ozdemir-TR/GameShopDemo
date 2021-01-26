using GameShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopDemo.Abstract
{
    public interface IUserService //user için istenen işlemlerin interface i 
    {
        void  Save(User user);
        void Delete(User user);
        void Update(User user);
    }
}
