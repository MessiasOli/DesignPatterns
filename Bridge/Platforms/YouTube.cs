using System;

namespace Bridge.Platforms
{
    class YouTube : IPlatform
    {
        public YouTube()
        {
            ConfigureRMTP();
            Console.WriteLine("Youtube: Transmissão Iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Youtube: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Youtube: Configurando servidor RMTP.");
        }
    }
}
