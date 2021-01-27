using System;
using System.Collections.Generic;
using System.Text;

namespace GameServiceDemo
{
    class Player : Person
    {
        public Player()
        {

        }
        public Player(string username, string password, int wallet)
        {
            UserName = username;
            Password = password;
            Wallet = wallet;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Wallet { get; set; }
    }
}
