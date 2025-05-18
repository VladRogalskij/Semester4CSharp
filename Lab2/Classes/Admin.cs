using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Admin : User
    {
        public void BlockUser(User user)
        {
            Console.WriteLine($"Користувача {UserName} заблоковано.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(", Роль: Адміністратор");
        }
    }
}
