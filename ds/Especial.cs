using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    class Especial : Generica
    {
        public Especial() { graeack(); }
        public override void saludar()
        {
            Console.WriteLine("Saludando desde clase generica sobreescrita");
        }

        public void graeack()
        {
            Console.WriteLine("Saludando desde clase especifica graeack");
        }
    }
}
