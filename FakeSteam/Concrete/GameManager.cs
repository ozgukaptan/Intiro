using FakeSteam.Abstract;
using FakeSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeSteam.Concrete
{
    class GameManager : IGameService
    {
       

        public bool BuyGame(User user, Game game)
        {
            Console.WriteLine("Satış yapıldı. satın alan kişi : " + user.FirstName.ToString() + " Satış Fiyatı : " + game.price.ToString());
            return true;
        }

        public bool BuyGame(User user, Game game, Campain campain)
        {
            Console.WriteLine("Satış yapıldı. satın alan kişi : " + user.FirstName.ToString() + " Satış Fiyatı : " + (game.price - ((game.price / 100) * campain.DiscountRate)).ToString() + " TL  Kampanya ismi : " + campain.Name.ToString());
            return true;
        }
    }
}
