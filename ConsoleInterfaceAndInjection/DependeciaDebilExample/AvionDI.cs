using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterfaceAndInjection.DependeciaDebilExample
{
    public class AvionDI : IVehiculo
    {

        public string Acelerar()
        {
            return "Avion DI acelerando";
        }

        public string Frenar()
        {
            return "Avion DI frenando";
        }
    }
}
