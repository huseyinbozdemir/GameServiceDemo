using System;
using System.Collections.Generic;
using System.Text;

namespace GameServiceDemo
{
    class WinterDiscount : SalesServices
    {
        public void Discount(Entity game)
        {
            Console.WriteLine(game.Name + " oyununa kış indirimi yapıldı.");
        }
    }
}
