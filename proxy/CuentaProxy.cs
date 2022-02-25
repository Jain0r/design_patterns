using System;
using System.Collections.Generic;
using System.Text;

namespace proxy
{
    class CuentaProxy : ICuenta
    {
        ICuenta cuentaReal;
        public CuentaProxy(ICuenta cuentaReal)
        {
            this.cuentaReal = cuentaReal;
        }

        public CuentaDatos depositar(CuentaDatos cuenta, int cantidad)
        {
            if(this.cuentaReal == null)
            {
                this.cuentaReal= new cuentaBancoA();
                return cuentaReal.depositar(cuenta, cantidad);
            } 
            else
            {
                return cuentaReal.depositar(cuenta, cantidad);
            }
        }

        public CuentaDatos retirar(CuentaDatos cuenta, int cantidad)
        {
            if (this.cuentaReal == null)
            {
                this.cuentaReal = new cuentaBancoA();
                return cuentaReal.retirar(cuenta, cantidad);
            }
            else
            {
                return cuentaReal.retirar(cuenta, cantidad);
            }
        }

        public void mostrarCantidad(CuentaDatos cuenta)
        {
            if (this.cuentaReal == null)
            {
                this.cuentaReal = new cuentaBancoA();
                cuentaReal.mostrarCantidad(cuenta);
            }
            else
            {
                cuentaReal.mostrarCantidad(cuenta);
            }
        }

    }
}
