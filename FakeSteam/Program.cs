using FakeSteam.Abstract;
using FakeSteam.Concrete;
using FakeSteam.Entities;
using System;

namespace FakeSteam
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User { BirthYear = 1987, FirstName = "özgü", LastName = "kaptan", IdentityNumber = 12345 };
            Game game = new Game { Id = 1, Name = "Age Of Empire", price = 100 };
            Campain campain10 = new Campain { DiscountRate = 10, Id = 1, Name = "Yüzde 10 indirim" };
            Campain campain20 = new Campain { DiscountRate = 20, Id = 1, Name = "Yüzde 20 indirim" };



            UserManager userManager = new UserManager(new UserValidationManager());
            userManager.Add(new User { BirthYear = 1987, FirstName = "özgü", LastName = "kaptan", IdentityNumber = 12345 });


            GameManager gameManager = new GameManager();

            gameManager.BuyGame(user, game);
            gameManager.BuyGame(user, game, campain10);
            gameManager.BuyGame(user, game, campain20);


        }
    }
}
