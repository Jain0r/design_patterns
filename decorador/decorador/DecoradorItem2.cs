using System;
using System.Collections.Generic;
using System.Text;

namespace decorador
{
    class DecoradorItem2 : Decorador 
    {
        public DecoradorItem2(I_Inventario componente) : base(componente) { }

        //new public string adquirirItem()
        //{
        //    return base.adquirirItem() + "vandal";
        //}

        override public string adquirirItem()
        {
            DecoroConcreto2();
            return base.adquirirItem() + " y vandal";
        }

        public void DecoroConcreto2()
        {
            Console.WriteLine("item 2 decorado");
        }
    }
}
