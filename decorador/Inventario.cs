using System;
using System.Collections.Generic;
using System.Text;

namespace decorador
{
    class Inventario : I_Inventario
    {
        public string arma = "Clasic";

        public Inventario()
        {
            //this.arma = Caracterisitca;
        }

        public void VenderItem()
        {
            Console.WriteLine("Vendiendo Item");
        }

        public void CombinarItem()
        {
            Console.WriteLine("Combinando Item");
        }

        //METODOS DE LA INTERFAZ
        public string adquirirItem()
        {
            return arma;
        }
    }
}
