using GameShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopDemo.Abstract
{
    public interface IgameSellService // oyun satışı için gerekli sell işleminin interface i.
    {
        void Sell(User user , Game game ,Campaign campaign);
    }
}
