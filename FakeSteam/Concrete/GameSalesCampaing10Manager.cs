using FakeSteam.Abstract;
using FakeSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeSteam.Concrete
{
    class GameSalesCampaing10Manager : ISalesCampaingService
    {
        public int ApplyCampaign(User user, Game game)
        {
            return (int)(game.price * 0.9);
        }
    }
}
