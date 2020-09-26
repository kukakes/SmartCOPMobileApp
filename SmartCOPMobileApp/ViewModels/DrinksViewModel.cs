using SmartCOPMobileApp.Models;
using SmartCOPMobileApp.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SmartCOPMobileApp.ViewModels
{
    class DrinksViewModel : ObservableObject
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

        public string CollectionDetails 
        { 
            get => $"{string.Join(". ", Drinks.Select(d => d.Description()))}.";
            set { }
        }
    }
}
