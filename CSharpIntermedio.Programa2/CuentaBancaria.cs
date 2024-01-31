using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermedio.Programa2
{
    public class CuentaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public CuentaBancaria(string titular, double saldoInicial) 
        {
            this.Titular = titular;
            this.Saldo = saldoInicial;
        }

        public void Depositar(double monto)
        {
            if (monto > 0)
            {
                Saldo += monto;
                Console.WriteLine($"Cliente: {Titular} ha depositado {monto:C} de forma exitosa. Su nuevo saldo es de {Saldo:C}.\n");
            }
            else
            {
                Console.WriteLine("Depósito no procesado. El monto debe ser mayor a cero.\n");
            }
        }

        public void Retirar(double monto)
        {
            if (monto > 0 && monto < Saldo)
            {
                Saldo -= monto;
                Console.WriteLine($"Cliente: {Titular} ha retirado {monto:C} de forma exitosa. Su saldo disponible es de {Saldo:C}\n");
            }
            else if (monto <= 0)
            {
                Console.WriteLine("El monto de retiro debe ser mayor que cero.\n");
            }
            else
            {
                Console.WriteLine("Retiro no procesado. Saldo insuficiente.\n");
            }
        }
    }
}
