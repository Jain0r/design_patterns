using System;
using System.Collections.Generic;
using System.Text;

namespace proxy
{
    class cuentaBancoA : ICuenta
    {
        public CuentaDatos retirar(CuentaDatos cuenta, int cantidad)
        {
            cuenta.saldo -= cantidad;
            return cuenta;
        }

        public CuentaDatos depositar(CuentaDatos cuenta, int cantidad)
        {
            cuenta.saldo += cantidad;
            return cuenta;
        }

        public void mostrarCantidad(CuentaDatos cuenta)
        {
            Console.WriteLine("Cantidad de la cuenta es de: {0}.", cuenta.saldo);
        }

    }
}
