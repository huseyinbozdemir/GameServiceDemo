using System;
using System.Collections.Generic;
using System.Text;

namespace GameServiceDemo
{
    class Game : Entity
    {
        public Game()
        {

        }
        public Game(int id, string name, string producer, int unitPrice)
        {
            Id = id;
            Name = name;
            Producer = producer;
 
            UnitPrice = unitPrice;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public int UnitPrice { get; set; }
    }
}
