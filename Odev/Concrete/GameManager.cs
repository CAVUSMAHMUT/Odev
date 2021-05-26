using Odev.Abstract;
using Odev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName +"Oyun Sepete eklendi");
        }

        public void Deleted(Game game)
        {
            Console.WriteLine("Ürün sepetten silindi");
        }

        public void Uptade(Game game)
        {
            Console.WriteLine("Ürün güncellendi");
        }
    }
}
