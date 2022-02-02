using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterfaceAndInjection.DependeciaFuerteExample
{
    public class Soldado
    {
        Tanque tanque = new Tanque();
        Avion  avion  = new Avion();
      //  Escopeta escopeta = new Escopeta();

        public string  AcelerarAvion()
        {
            return avion.Acelerar();
        }
        public string FrenarAvion()
        {
            return avion.Frenar();
        }

        public string AcelerarTanque()
        {
            return tanque.Acelerar();
        }
        public string FrenarTanque()
        {
            return tanque.Frenar();
        }
    }
}
