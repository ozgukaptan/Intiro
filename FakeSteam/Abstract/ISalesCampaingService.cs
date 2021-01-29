using FakeSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeSteam.Abstract
{
    interface ISalesCampaingService
    {
        public int ApplyCampaign(User user, Game game);
    }
}
