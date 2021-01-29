using FakeSteam.Abstract;
using FakeSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeSteam.Concrete
{
    class UserManager : IUserService
    {
        IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(User user)
        {
            if(_userValidationService.Validate(user))
            {
                Console.WriteLine("kayıt oldu");
            }
            else
            {
                Console.WriteLine("Kişi doğru değil");
            }
        }

        public void Delete(User user)
        {
            Console.WriteLine("Silindi");
        }

        public void Update(User user)
        {
            Console.WriteLine("Guncellendi");
        }
    }
}
