using AbstractFactory.App;
using AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static Application ConfigureApplication()
        {
            Application app;

            ITransportFactory transportFactory;
            string company = "Aline";

            if(company == "Uber")
            {
                transportFactory = new UberTransport();
            }
            else if (company == "99")
            {
                transportFactory = new NineNineTransport();
            }
            else
            {
                transportFactory = new AlineTransport();
            }

            app = new Application(transportFactory);

            return app;
        }

        static void Main(string[] args)
        {
            Application app = ConfigureApplication();

            app.StartRoute();

            Console.ReadLine();
        }
    }
}
