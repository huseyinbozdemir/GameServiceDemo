using System;
using System.Collections.Generic;
using System.Text;

namespace GameServiceDemo
{
    class SummerDiscount : SalesServices
    {
        public void Discount(Entity game)
        {
            Console.WriteLine(game.Name + " oyununa yaz indirimi yapıldı.");
        }
    }
}
