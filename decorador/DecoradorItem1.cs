using System;
using System.Collections.Generic;
using System.Text;

namespace decorador
{
    class DecoradorItem1 : Decorador
    {
        //private IComponente decoramos;

        public DecoradorItem1(I_Inventario componente) : base (componente)
        { }

        //new public string adquirirItem()
        //{
        //    DecoroConcreto();
            

        //    return "ghost";
        //}

        new public string adquirirItem()
        {
            DecoroConcreto();
            return "ghost";
        }

        public void DecoroConcreto()
        {
            Console.WriteLine("item 1 decorado");
        }
    }
}
