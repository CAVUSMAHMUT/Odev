using Odev.Abstract;
using Odev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev.Concrete
{
    public class GameSaleManager : IGameSaleService
    {
        public void Sale(Gamer gamer, Game game, Campaings campaings)
        {
            double newPrice = game.GamePrice - (game.GamePrice * (campaings.CampaignDiscount / 100));
            Console.WriteLine(game.GameName + " oyunu " + gamer.FirstName + " " + gamer.LastName + " kişisine satıldı.");
            Console.WriteLine("Oyunun indirimli Fiyatı : " + newPrice + " TL");
            Console.WriteLine("Uygulanan İndirim fiyatı : " + game.GamePrice * (campaings.CampaignDiscount / 100) + " TL");
        }
    }
}
