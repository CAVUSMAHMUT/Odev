using Odev.Concrete;
using Odev.Entities;
using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game
            {
                GameName = "Last Of Us 2",
                GameCategory = "Hayatta Kalma",
                GamePrice = 250
            };
            Game game2 = new Game
            {
                GameName = "Uncharted 4",
                GameCategory = "Macera",
                GamePrice = 350
            };
            Game game3 = new Game
            {
                GameName = "God Of War",
                GameCategory = "Aksiyon, Dövüş",
                GamePrice = 450
            };

           
            Campaings campaign1 = new Campaings();
            campaign1.CampaignName = "Yaz İndirimi";
            campaign1.CampaignDiscount = 50;

            Campaings campaign2 = new Campaings();
            campaign2.CampaignName = "Haftasonu İndirimi";
            campaign2.CampaignDiscount = 25;


            
            Gamer gamer1 = new Gamer
            {
                FirstName = "MAHMUT",
                LastName = "ÇAVUŞ",
                NationaltyId = "12345678910",
                DateOfBirth = new DateTime(1985, 1, 6)
            };
            Gamer gamer2 = new Gamer
            {
                FirstName = "HASAN",
                LastName = "AYDIN",
                NationaltyId = "10987654321",
                DateOfBirth = new DateTime(1998, 10, 20)
            };

            
            GamerManager gamerManager = new GamerManager(new IVerifictionManager());
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Update(gamer1);

            Console.WriteLine("************************");

            
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Console.WriteLine("-------------------------");


            gameManager.Add(game2);

            Console.WriteLine("************************");

            
            CampaingManager campaignManager = new CampaingManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            Console.WriteLine("************************");

            
            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(gamer1, game1, campaign1);

            Console.WriteLine("************************");

            gameSaleManager.Sale(gamer2, game3, campaign2);






            Console.ReadLine();
        }
    }
}
