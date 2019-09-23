using System;
using FluentAssertions;
using Machine.Specifications;

namespace PriceTracker.Spec
{
    
    public class when_carrots_are_cheap_enough
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Restaurant("Byron's Flavor Town", 0.81);
            _veggies = new Carrots(0.82);
            _veggies.Add(_systemUnderTest);
        };

        Because of = () => { _veggies.PricePerPound = 0.80; };
        It should_buy_some_carrots = () => { _systemUnderTest.BoughtVeggies.Should().Be(1); };
        static Restaurant _systemUnderTest;
        static Carrots _veggies;
    }

    public class when_carrots_are_cheap_but_peppers_expensive
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Restaurant("Andres' Crazy Pizzas", 0.76);
            _carrots = new Carrots(0.82);
            _peppers = new Peppers(0.91);
            _carrots.Add(_systemUnderTest);
            _peppers.Add(_systemUnderTest);
        };

        Because of = () =>
        {
            _carrots.PricePerPound = 0.73;
            _peppers.PricePerPound = 0.95;
            _peppers.PricePerPound = 0.75;
        };


        It should_buy_carrots_and_peppers_once = () => { _systemUnderTest.BoughtVeggies.Should().Be(2); };
        
        static Restaurant _systemUnderTest;
        static Carrots _carrots;
        static Peppers _peppers;
    }
    
}