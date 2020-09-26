using SmartCOPMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SmartCOPMobileApp.ViewModels
{
    class DrinksViewModel
    {
        public ObservableCollection<Drink> Drinks { get; set; } =
            new ObservableCollection<Drink>();

        public DrinksViewModel()
        {
            Drinks.Add(new Juice()
            {
                Name = "Orange Juice",
                IsCarbonated = false,
                MadeFrom = "oranges"
            });

            Drinks.Add(new Beer()
            {
                Name = "Budweiser",
                AlchocolContent = 5,
                IsCarbonated = true
            });

            Drinks.Add(new Soda()
            {
                Name = "Pepsi",
                IsCarbonated = true
            });
        }
    }
}
