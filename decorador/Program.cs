using System;

namespace decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            I_Inventario instanciaComponente = new Inventario();

            I_Inventario decorado1 = new DecoradorItem1(instanciaComponente);

            I_Inventario decorado2 = new DecoradorItem2(decorado1);
            //instanciaComponente = new DecoradorItem1(instanciaComponente);


            //((DecoradorItem1)instanciaComponente).DecoroConcreto();

            //instanciaComponente = new DecoradorItem2(instanciaComponente);

            //decorador = new DecoradorItem2(instanciaComponente);
            //decorador.MetodoGenerico();

            Console.WriteLine(((DecoradorItem2)decorado2).adquirirItem());

            Console.WriteLine(decorado2.adquirirItem());

        }
    }
}
