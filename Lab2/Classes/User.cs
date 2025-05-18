using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class User
    {
        public string UserName {  get; set; }
        public string Email {  get; set; }
        private string _password;
        protected bool _isAuthenticated;

        public void SetPassword(string newPassword)
        {
            if(_isAuthenticated || string.IsNullOrEmpty(_password))
            {
                _password = newPassword;
            }
            else
            {
                Console.WriteLine("You must be authorized before changing the password.");
            }
        }
        public bool Authenticate(string inputPassword)
        {
            _isAuthenticated = inputPassword == _password;
            return _isAuthenticated;
        }
        public virtual void DisplayInfo()
        {
            Console.Write($"Name: {UserName}, Email: {Email}");
        }
    }
}
