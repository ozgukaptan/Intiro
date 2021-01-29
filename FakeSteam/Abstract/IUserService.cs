using FakeSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeSteam.Abstract
{
    interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
