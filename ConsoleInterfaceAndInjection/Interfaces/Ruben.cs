using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterfaceAndInjection.Interfaces
{
    public class Ruben :IHumano
    {
        public void Respirar()
        {
            Console.WriteLine("Ruben tiene ASMA ");
        }
    }
}
