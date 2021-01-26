using GameShopDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopDemo.Entities
{
    //Sistemde bulunan oyun ve özellikleri.
    public class Game 
    {
        public int GameId { get; set; }
        public double GamePrice { get; set; }
        public string GameName { get; set; }
    }
}
