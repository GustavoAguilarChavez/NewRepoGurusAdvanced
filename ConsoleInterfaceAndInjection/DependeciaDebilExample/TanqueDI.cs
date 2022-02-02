using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterfaceAndInjection.DependeciaDebilExample
{
    public class TanqueDI : IVehiculo
    {

        public string Acelerar()
        {
            return "Tanque DI acelerando";
        }

        public string Frenar()
        {
            return "Tanque DI frenando";
        }
    }
}
