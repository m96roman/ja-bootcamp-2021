using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Models;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    public class HeroActions : IHeroActions
    {
        Hero _hero;

        public HeroActions(Hero hero)
        {
            _hero = hero;
        }

        public string GetFullName()
        {
            return $"{_hero.FirstName} {_hero.LastName}";
        }

        public decimal GetBalance()
        {
            return _hero.Balance;
        }

        public void IncreaseBalance(decimal amount)
        {
            _hero.Balance += amount;
        }

        public void IncreaseSalary(decimal amount)
        {
            _hero.Salary += amount;
        }

        public void DecreaseSalary(decimal amount)
        {
            _hero.Salary -= amount;
        }

        public void PaySalary()
        {
            _hero.Balance += _hero.Salary;
        }

        public void SendGreeting(string text)
        {
            string destination = $"{_hero.PostIndex} {_hero.Street}, {_hero.City}, {_hero.Country}";
            Console.WriteLine($"Sending letter with context '{text}' to destination {destination}");
        }
    }
}
