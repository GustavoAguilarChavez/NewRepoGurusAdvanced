using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterfaceAndInjection.DependeciaDebilExample
{
    public class RevolverDI : IArma
    {
        public string Disparar()
        {
            return "Disparando Revolver DI";
        }

        public string Recargar()
        {
            return "Recargando Revolver DI";
        }
    }
}
