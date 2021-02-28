using ChainOfResponsibility.Servers;
using System;

namespace ChainOfResponsibility.Middlewares
{
    class CheckUserMiddleware : Middleware
    {
        private Server server;

        public CheckUserMiddleware(Server server)
        {
            this.server = server;
        }

        public override bool Check(string email, string passwaord)
        {
            if (!server.HasEmail(email))
            {
                Console.WriteLine("E-mail Inválido.");
            }

            if (!server.IsValidPassword(email, passwaord))
            {
                Console.WriteLine("E-mail e/ou Senha Inválidos!");
                return false;
            }

            return CheckNext(email, passwaord);
        }
    }
}
