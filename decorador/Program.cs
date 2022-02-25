using System;

namespace decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            I_Inventario instanciaComponente = new Inventario();

            instanciaComponente = new DecoradorItem1(instanciaComponente);

            instanciaComponente = new DecoradorItem2(instanciaComponente);

            Console.WriteLine(instanciaComponente.adquirirItem());

            //instanciaComponente.VenderItem();
        }
    }
}
