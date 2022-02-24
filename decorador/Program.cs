using System;

namespace decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            I_Inventario instanciaComponente = new Inventario();


            instanciaComponente = new DecoradorItem1(instanciaComponente);

            //instanciaComponente = new DecoradorItem2(instanciaComponente);

            //((Inventario)instanciaComponente)

            //Console.WriteLine(instanciaComponente.adquirirItem());

            Console.WriteLine(((Inventario)instanciaComponente).arma);
        }
    }
}
