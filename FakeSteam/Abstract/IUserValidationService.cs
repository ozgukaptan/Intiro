using FakeSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeSteam.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(User user);
    }
}
