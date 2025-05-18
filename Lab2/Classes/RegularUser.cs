using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class RegularUser: User
    {
        void PostComment()
        {
            Console.WriteLine("Коментар опубліковано.");
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(", Роль: Звичайний користувач");
        }
    }
}
