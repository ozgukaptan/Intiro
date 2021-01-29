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

           

            UserManager userManager = new UserManager(new UserValidationManager());
            userManager.Add(new User { BirthYear = 1987, FirstName = "özgü", LastName = "kaptan", IdentityNumber = 12345 });


            GameManager gameManager10 = new GameManager(new GameSalesCampaing10Manager());

            gameManager10.BuyGame(user, game);

            GameManager gameManager20 = new GameManager(new GameSalesCampaing20Manager());

            gameManager20.BuyGame(user, game);

        }
    }
}
