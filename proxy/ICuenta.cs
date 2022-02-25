using System;
using System.Collections.Generic;
using System.Text;

namespace proxy
{
    interface ICuenta
    {
        CuentaDatos retirar(CuentaDatos cuenta, int cantidad);

        CuentaDatos depositar(CuentaDatos cuenta, int cantidad);

        void mostrarCantidad(CuentaDatos cuenta);
    }
}
