using Lab3.Abstract_Classes_and_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Classes
{
    internal class BreakableWall : IDamageable
    {
        public float HealPoint { get; set; }
        public bool IsDestroyed { get; set; }

        public BreakableWall(float healPoint)
        {
            HealPoint = healPoint;
        }
        public void ShowInfo()
        {
            if (IsDestroyed)
            {
                Console.WriteLine("The Wall already destroyed");
            }
            else
            {
                Console.WriteLine($"Current Wall HP - {HealPoint}");
            }
        }
    }
}
