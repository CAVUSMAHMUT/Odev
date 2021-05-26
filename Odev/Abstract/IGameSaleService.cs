using Odev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev.Abstract
{
    public interface IGameSaleService
    {
        void Sale(Gamer gamer, Game game, Campaings campaings);
    }
}
