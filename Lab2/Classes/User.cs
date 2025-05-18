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
            if(_isAuthenticated || _password == String.Empty)
            {
                _password = newPassword;
            }
        }
        public bool Authenticate(string inputPassword, string inputEmail)
        {
            _isAuthenticated = inputPassword == _password && Email == inputEmail;
            return _isAuthenticated;
        }
        public virtual void DisplayInfo()
        {
            Console.Write($"UserName: {UserName}, Email: {Email}");
        }
    }
}
