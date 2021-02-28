using Builder.Components;

namespace Builder.Products
{
    class Vehicle
    {
        private VehicleType vehicleType;
        private int seats;
        private Engine engine;
        private Airbag airbag; 
        private Trasnmission trasnmission;

        public VehicleType VehicleType
        {
            get => vehicleType;
            set => vehicleType = value;
        }

        public int Seats
        {
            get => seats;
            set => seats = value;
        }
        
        public Engine Engine
        {
            get => engine;
            set => engine = value;
        }
        
        public Trasnmission Trasnmission
        {
            get => trasnmission;
            set => trasnmission = value;
        }
        public Airbag Airbag
        {
            get => airbag;
            set => airbag = value;
        }
    }
}
