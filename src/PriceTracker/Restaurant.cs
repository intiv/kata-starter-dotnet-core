using System;
using System.Linq;

namespace PriceTracker
{
    public class Restaurant : IRestaurant
    {
        readonly string _name;
        readonly double _priceThreshold;
        public int BoughtVeggies { get; private set; }
        public Restaurant(string name, double priceThreshold)
        {
            _name = name;
            _priceThreshold = priceThreshold;
            BoughtVeggies = 0;
        }

        public void Update(Veggies veggies)
        {
            if (veggies.PricePerPound > _priceThreshold) return;
            BoughtVeggies++;
        }

    }
}