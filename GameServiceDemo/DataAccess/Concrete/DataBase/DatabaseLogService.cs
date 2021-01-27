using System;
using System.Collections.Generic;
using System.Text;

namespace GameServiceDemo
{
    class DatabaseLogService : LoggerService
    {
        public void Add(Entity entity) {
            Console.WriteLine(entity.Name + " veritabanına eklenmiştir.");
        }
        public void Update(Entity entity) {
            Console.WriteLine(entity.Name + " bilgileri güncellenmiştir.");
        }
        public void Remove(Entity entity) {
            Console.WriteLine(entity.Name + " veritabanından silinmiştir.");
        }
    }
}
