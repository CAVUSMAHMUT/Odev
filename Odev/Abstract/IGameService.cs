using Odev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Deleted(Game game);
        void Uptade(Game game);

    }
}
