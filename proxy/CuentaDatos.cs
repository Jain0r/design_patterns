using System;
using System.Collections.Generic;
using System.Text;

namespace proxy
{
    class CuentaDatos
    {
        public CuentaDatos(String usu, int id, int sal)
        {
            this.usuario = usu;
            this.idCuenta = id;
            this.saldo = sal;
        }

        public string usuario;

        public int idCuenta;

        public int saldo;
    }
}
