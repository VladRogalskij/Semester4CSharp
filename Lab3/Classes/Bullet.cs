using Lab3.Abstract_Classes_and_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Classes
{
    internal class Bullet : Projectile
    {
        public Bullet(float damage)
        {
            _damage = damage;
        }

        public override void HitTarget(IDamageable damageable)
        {
            if (damageable.IsDestroyed == false)
            {
                damageable.HealPoint -= _damage;
                Console.WriteLine($"{damageable} gets {_damage} damage");

                if (damageable.HealPoint <= 0)
                {
                    damageable.IsDestroyed = true;
                    Console.WriteLine("Target has been destroyed");
                }
            }
        }
    }
}
