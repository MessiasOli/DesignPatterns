using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    abstract class Transport
    {
        public void StartTrasnport()
        {
            IVehicle vehicle = CreateTransport();
            vehicle.StartRoute();
        }

        protected abstract IVehicle CreateTransport();
            
    }
}
