using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCOPMobileApp.Models
{
    /// <summary>
    /// Derived class Soda
    /// </summary>
    public class Soda : Drink
    {
        public override string Description() => $"{Name}, {CarbonatedDescription}";
    }
}
