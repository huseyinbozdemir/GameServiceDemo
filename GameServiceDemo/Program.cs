using System;
using System.Collections.Generic;

namespace GameServiceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerService databaseLogger = new DatabaseLogService();
            ValidateService validatePerson = new MernisValidateService();

            Person yunusemre = new Player() {IdentificationNumber= "11111111111", Name="Yunus Emre", LastName="ÇETİN", YearOfBith=2000, Wallet=1100};
            Person batuhan = new Player() { IdentificationNumber = "22222222222", Name = "Batuhan", LastName = "DEMİR", YearOfBith = 1996, Wallet = 750 };
            Person huseyin = new Player() { IdentificationNumber = "3333333333", Name = "Hüseyin", LastName = "BOZ", YearOfBith = 2005, Wallet = 900 };
            EntityService personManager = new PlayerManager(new List<LoggerService> { databaseLogger }, new List<ValidateService> { validatePerson });
            personManager.Add(yunusemre);
            personManager.Add(huseyin);
            personManager.Add(batuhan);

            Entity erzurum = new Game() { Id=1, Name="Erzurum", Producer="Proximity Games", UnitPrice=60};
            Entity rdr2 = new Game() { Id = 1, Name = "Red Dead Redemption2", Producer = "Rockstar Games", UnitPrice = 250 };
            Entity cyberpunk = new Game() { Id = 1, Name = "CyberPunk 2077", Producer = "CD Projekt Red", UnitPrice = 250 };
            EntityService gameManager = new GameManager(new List<LoggerService> { databaseLogger });
            gameManager.Add(erzurum);
            gameManager.Add(rdr2);
            gameManager.Add(cyberpunk);

            SalesServices winterDiscount = new WinterDiscount();
            SalesServices summerDiscount = new SummerDiscount();
            PlatformService steamPlatform = new SteamPlatform(new List<SalesServices> { winterDiscount });
            PlatformService epicGamesPlatform = new EpicGamesPlatform(new List<SalesServices> { });

            epicGamesPlatform.BuyGame(yunusemre,erzurum);
            steamPlatform.BuyGame(batuhan,erzurum);
            epicGamesPlatform.Refund(yunusemre,erzurum);
            steamPlatform.BuyGame(yunusemre,erzurum);
            steamPlatform.BuyGame(yunusemre,cyberpunk);
        }
    }
}
