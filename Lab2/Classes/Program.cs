using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User> 
            {
                new RegularUser { UserName = "RegUser", Email = "user@example.com" },
                new Admin { UserName = "AdminUser", Email = "admin@example.com" },
                new Moderator { UserName = "ModUser", Email = "mod@example.com" },   
            };

            foreach (var user in users)
            {
                user.DisplayInfo();
            }
            Console.WriteLine();

            foreach (User user in users)
            {
                if (user is Admin admin)
                {
                    admin.BlockUser(users[2]);
                }
                else if (user is Moderator mod)
                {
                    mod.ModerateContent();
                }
                else if (user is RegularUser reg)
                {
                    reg.PostComment();
                }
            }
            Console.WriteLine();

            foreach (User user in users)
            {
                user.DisplayInfo();
                Console.Write("Enter password: ");
                user.SetPassword(Console.ReadLine());
            }

            foreach (User user in users)
            {
                user.DisplayInfo();
                Console.Write("Enter password to authenticate: ");

                string inputPassword = Console.ReadLine();
                string status = user.Authenticate(inputPassword) ? "Успішна аутентифікація" : "Невірний пароль";
                Console.WriteLine($"{user.UserName}: {status}");
            }

            Console.ReadKey();
        }
    }
}
