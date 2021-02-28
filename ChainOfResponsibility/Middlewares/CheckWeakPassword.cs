using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Middlewares
{
    class CheckWeakPassword : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password.Equals("123456"))
            {
                Console.WriteLine("Atenção - Sua senha é uma senha fraca, por favor registre outra senha.");
                return CheckNext(email, password);
            }

            return CheckNext(email, password);

        }
    }
}
