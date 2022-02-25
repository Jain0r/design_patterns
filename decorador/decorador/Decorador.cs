using System;
using System.Collections.Generic;
using System.Text;

namespace decorador
{
    abstract class Decorador : I_Inventario
    {
        protected I_Inventario decoramosA;

        public Decorador(I_Inventario componente)
        {
            decoramosA = componente;
        }

        virtual public string adquirirItem()
        {
            return decoramosA.adquirirItem();
        }

    }
}
