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

        public new string adquirirItem()
        {
            DecoroConcreto();
            //return "";
            return base.adquirirItem() + "vandal";
        }

        public void DecoroConcreto()
        {
            Console.WriteLine("Decoro item secundario");
        }
    }
}
