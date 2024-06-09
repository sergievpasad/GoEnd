using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GoEnd
{
    class CheckThePassword
    {
        private bool CorrectPassword = false;

        private string TruePassword { get; set; }

        private void ChekingPassword(string Password)
        {
            
            if(Password ==TruePassword)
            {
                CorrectPassword = true;
            }
            Console.Clear();
        }

        private void ReadPassword()
        {
            string a = Console.ReadLine();
            ChekingPassword(a);
        }

        public void CheckPaswword()
        {
            TruePassword = "ZXC";
            while(!CorrectPassword)
            {
                Console.Write("Введите пароль: ");
                ReadPassword();
            }
        }
    }
}
