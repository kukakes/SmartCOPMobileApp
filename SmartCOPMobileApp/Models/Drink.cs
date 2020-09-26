using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCOPMobileApp.Models
{
    /// <summary>
    /// Abstract base class which can't be instantiated
    /// </summary>
    public abstract class Drink
    {
        public string Name { get; set; }
        public bool IsCarbonated { get; set; }

        /// <summary>
        /// Property to generate carbonated display content
        /// </summary>
        protected string CarbonatedDescription
        {
            get => IsCarbonated ? "carbonated" : "not carbonated";
        }

        public virtual string Description() => string.Empty;
    }
}
