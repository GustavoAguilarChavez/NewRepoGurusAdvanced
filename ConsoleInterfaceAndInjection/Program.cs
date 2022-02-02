using ConsoleInterfaceAndInjection.DependeciaDebilExample;
using ConsoleInterfaceAndInjection.DependeciaFuerteExample;
using System;

namespace ConsoleInterfaceAndInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Fuertemente acoplado");
            Soldado SoldadoGAC = new Soldado();
            Console.WriteLine(SoldadoGAC.AcelerarAvion());
            Console.WriteLine(SoldadoGAC.AcelerarTanque());
            Console.WriteLine("*************************************");

            //SoldadoDI soldadoinyector = new SoldadoDI(new EscopetaDI(), new TanqueDI());
            //soldadoinyector.Disparar();
            //soldadoinyector.Acelerar();
            Console.ReadLine();
        }

        


    //inyectar IViaComunicacion a soldado
    //el soldado podra usar Radio, Fax
    //las acciones seran TransmitirMensaje ->string
    //usarlo en program
}
}
