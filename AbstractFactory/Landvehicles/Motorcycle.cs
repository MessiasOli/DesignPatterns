using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Landvehicles
{
    class Motorcycle : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos a entrega");
        }
    }
}
