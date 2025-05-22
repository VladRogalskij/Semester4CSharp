using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Abstract_Classes_and_Interfaces
{
    internal abstract class Projectile
    {
        protected float _damage;
        public abstract void HitTarget(IDamageable damageable);
    }
}
