using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.Factories
{
    class AlineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Drone();
        }

        public ILandvehicle CreateTrasnportVehicle()
        {
            return new Patnet();
        }
    }
}
