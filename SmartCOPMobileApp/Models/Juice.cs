using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCOPMobileApp.Models
{
    /// <summary>
    /// Derived class Juice
    /// </summary>
    public class Juice : Drink
    {
        public string MadeFrom { get; set; }

        public override string Description() => $"{Name}, {CarbonatedDescription}, made from {MadeFrom}";
    }
}
