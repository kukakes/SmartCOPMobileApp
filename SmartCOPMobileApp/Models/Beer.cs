using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCOPMobileApp.Models
{
    /// <summary>
    /// Derived class Beer
    /// </summary>
    public class Beer : Drink
    {
        public int AlchocolContent { get; set; }

        public override string Description() => $"{Name}, {CarbonatedDescription}, {AlchocolContent}%";
    }
}
