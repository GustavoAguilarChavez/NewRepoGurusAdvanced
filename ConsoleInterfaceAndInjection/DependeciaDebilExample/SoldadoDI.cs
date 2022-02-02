using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterfaceAndInjection.DependeciaDebilExample
{
    public class SoldadoDI
    {
        private IVehiculo _vehiculo;
        private IArma _arma;

        public SoldadoDI(IArma arma, IVehiculo vehiculo)
        {
            this._vehiculo = vehiculo;
            this._arma = arma;
        }

        //public string Disparar()
        //{
        //    return _arma.Disparar();
        //}

        //public string Recargar()
        //{
        //    return _arma.Recargar();
        //}

        //public string Acelerar()
        //{
        //    return _vehiculo.Acelear();
        //}

        //public string Frenar()
        //{
        //    return _vehiculo.Frenar();
        //}
    }
}
