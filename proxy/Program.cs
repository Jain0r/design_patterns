using System;

namespace proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaDatos cuenta = new CuentaDatos("Aeaman", 1, 100);

            ICuenta proxyCta = new CuentaProxy(new cuentaBancoA());

            proxyCta.depositar(cuenta,50);
            proxyCta.retirar(cuenta, 100);
            proxyCta.mostrarCantidad(cuenta);

        }
    }
}
