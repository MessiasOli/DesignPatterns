using System;

namespace FactoryMethod.Vehicles
{
    class Bike : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Encomenda na mochila");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Pedalando até o destino");
        }
    }
}
