using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Abstract_Classes_and_Interfaces
{
    internal interface IDamageable
    {
        float HealPoint {  get; set; }
        bool IsDestroyed {  get; set; }
        void ShowInfo();

    }
}
