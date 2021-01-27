using System;
using System.Collections.Generic;
using System.Text;

namespace GameServiceDemo
{
    class EpicGamesPlatform : PlatformService
    {
        List<SalesServices> _salesServices;
        public EpicGamesPlatform(List<SalesServices> salesServices)
        {
            _salesServices = salesServices;
        }
        public void BuyGame(Entity person, Entity game)
        {
            foreach (var sals in _salesServices)
            {
                sals.Discount(game);
            }
            Console.WriteLine(person.Name + " " + game.Name + " oyununu Epic Games'ten satın aldı.");
        }
        public void Refund(Entity person, Entity game)
        {
            Console.WriteLine(person.Name + " " + game.Name + " oyununu Epic Games'e iade etti.");
        }
    }
}
