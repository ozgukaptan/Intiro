using FakeSteam.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeSteam.Entities
{
    class Campain : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DiscountRate { get; set; }

    }
}
