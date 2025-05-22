using Lab3.Abstract_Classes_and_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Classes
{
    internal class Enemy : IDamageable
    {
        public float HealPoint { get; set; }
        public bool IsDestroyed { get; set; }

        public Enemy(float healPoint)
        {
            HealPoint = healPoint;
        }
        public void ShowInfo()
        {
            if (IsDestroyed)
            {
                Console.WriteLine("The Enemy already destroyed");
            }
            else
            {
                Console.WriteLine($"Current Enemy HP - {HealPoint}");
            }
        }
    }
}
