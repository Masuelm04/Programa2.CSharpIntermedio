using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermedio.Programa2
{
    public class Cliente
    {
        private string nombre;
        private CuentaBancaria cuentaBancaria;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public CuentaBancaria CuentaBancaria
        {
            get { return cuentaBancaria; }
            set { cuentaBancaria = value; }
        }

        public Cliente(string nombre, double saldoInicial)
        {
            this.Nombre = nombre;
            this.CuentaBancaria = new CuentaBancaria(nombre, saldoInicial);
        }
    }
}
