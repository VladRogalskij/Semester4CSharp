using Lab3.Abstract_Classes_and_Interfaces;
using Lab3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bullet bullet = new Bullet(damage: 10);

            List<IDamageable> damageables = new List<IDamageable>()
            {
                new Enemy(healPoint: 15),
                new BreakableWall(healPoint: 50)
            };

            foreach (var damageable in damageables)
            {
                while (!damageable.IsDestroyed)
                {
                    damageable.ShowInfo();
                    bullet.HitTarget(damageable);
                }
                damageable.ShowInfo();
            }
            Console.ReadKey();
        }
    }
}
