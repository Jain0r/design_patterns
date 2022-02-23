using System;

namespace ds
{
    class Program
    {
        static void Main(string[] args)
        {
            Generica prueba = new Especial();

            prueba.saludar();

            Console.WriteLine(prueba);
            //((Especial)prueba).graeack();
        }
    }
}
