using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Ventos em ótimo estado, pronto para decolar");
        }

        public void CheckBatery()
        {
            Console.WriteLine("Bateria em 85%");
        }

        public void GetCargo()
        {
            Console.WriteLine("Carga Acoplada e a rota já esta definida!");
        }

        public void StartRoute()
        {
            CheckWind();
            CheckBatery();
            GetCargo();
            Console.WriteLine("Helices ligadas e levantando voo.");
        }
    }
}
