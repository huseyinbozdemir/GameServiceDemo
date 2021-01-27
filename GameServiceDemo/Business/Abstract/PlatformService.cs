using System;
using System.Collections.Generic;
using System.Text;

namespace GameServiceDemo
{
    interface PlatformService
    {
         void BuyGame(Entity person, Entity game) { }
         void Refund(Entity person, Entity game) { }
    }
}
