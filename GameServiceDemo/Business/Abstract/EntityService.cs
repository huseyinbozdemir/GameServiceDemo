using System;
using System.Collections.Generic;
using System.Text;

namespace GameServiceDemo
{
    interface EntityService
    {
         void Add(Entity entity) { }
         void Update(Entity entity) { }
         void Remove(Entity entity) { }
    }
}
