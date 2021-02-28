using Builder.Components;
using Builder.Products;
using System;

namespace Builder.Builders
{
    class VehicleBuilder : IBuilder
    {
        private Vehicle vehicle = new Vehicle();
        public Vehicle GetVehicle()
        {
            Vehicle result = vehicle;
            Reset();
            return result;
        }

        public void Reset()
        {
            vehicle = new Vehicle();
        }

        public void SetEngine(Engine engine)
        {
            vehicle.Engine = engine;
        }

        public void SetSeats(int seats)
        {
            vehicle.Seats = seats;
        }

        public void SetTransmission(Trasnmission trasnmission)
        {
            vehicle.Trasnmission = trasnmission;
        }

        public void SetVehicleType(VehicleType vehicleType)
        {
            vehicle.VehicleType = vehicleType;
        }

        public void SetAirbags(Airbag airbag)
        {
            vehicle.Airbag = airbag;
        }
    }
}
