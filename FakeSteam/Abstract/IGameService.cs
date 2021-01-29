using FakeSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeSteam.Abstract
{
    interface IGameService
    {
        public bool BuyGame(User user, Game game);
        
    }
}
