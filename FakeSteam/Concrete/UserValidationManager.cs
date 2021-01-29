using FakeSteam.Abstract;
using FakeSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeSteam.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if(user.BirthYear == 1987 
                && user.FirstName == "özgü" 
                && user.LastName == "kaptan" 
                && user.IdentityNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
