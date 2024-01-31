using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermedio.Programa2
{
    public class Banco
    {  
        private List<Cliente> clientes;

        public Banco()
        {
            clientes = new List<Cliente>();
        }

        public void AgregarCliente(Cliente cliente)
        {
            
            clientes.Add(cliente);
            Console.WriteLine($"El cliente {cliente.Nombre} ha sido agregado de forma exitosa.\n");      
        }

        public double CalcularDineroTotal()
        {
            double total = 0;

            foreach (var cliente in clientes)
            {
                total += cliente.CuentaBancaria.Saldo;
            }

            return total;
        }
    }
}
