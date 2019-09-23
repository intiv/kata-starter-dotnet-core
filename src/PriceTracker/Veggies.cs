using System.Collections;
using System.Collections.Generic;

namespace PriceTracker
{
    public abstract class Veggies
    {
        double _pricePerPound;
        List<IRestaurant> _observers = new List<IRestaurant>();
        public Veggies(double pricePerPound)
        {
            _pricePerPound = pricePerPound;
        }

        public void Add(IRestaurant restaurant)
        {
            _observers.Add(restaurant);
        }

        public void Remove(IRestaurant restaurant)
        {
            _observers.Remove(restaurant);
        }

        public void Notify()
        {
            foreach (var restaurant in _observers)
            {
                restaurant.Update(this);
            }
        }
        
        public double PricePerPound
        {
            get => _pricePerPound;
            set
            {
                if (_pricePerPound == value) return;
                _pricePerPound = value;
                Notify();
            }
        }
    }

}