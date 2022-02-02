using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterfaceAndInjection.DependeciaDebilExample
{
    public class EscopetaDI : IArma
    {
        public string Disparar()
        {
            return "Disparando Escopeta DI";
        }

        public string Recargar()
        {
            return "Recargando Escopeta DI";
        }
    }
}
