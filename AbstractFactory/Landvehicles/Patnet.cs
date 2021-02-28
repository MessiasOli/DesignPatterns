using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Landvehicles
{
    class Patnet : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Aparelho liberado para utilização");
        }

        public void StartRoute()
        {
            Console.WriteLine("Bateria em 100% e pronto para rodar");
        }
    }
}
