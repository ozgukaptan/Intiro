using FakeSteam.Abstract;
using FakeSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeSteam.Concrete
{
    class GameManager : IGameService
    {
        ISalesCampaingService _salesCampaing;

        public GameManager(ISalesCampaingService salesCampaing)
        {
            _salesCampaing = salesCampaing;
        }

        public bool BuyGame(User user, Game game)
        {
            Console.WriteLine("Satış yapıldı. satın alan kişi : " + user.FirstName.ToString() + " Satış Fiyatı : " + _salesCampaing.ApplyCampaign(user, game).ToString());
            return true;
        }


    }
}
