using CSharpIntermedio.Programa2;

Banco banco = new Banco();

Cliente cliente1 = new Cliente("Pedro", 1000);
Cliente cliente2 = new Cliente("Fernanda", 2000);
Cliente cliente3 = new Cliente("Carlos", 1500);

banco.AgregarCliente(cliente1);
banco.AgregarCliente(cliente2);
banco.AgregarCliente(cliente3);

cliente1.CuentaBancaria.Depositar(2000);
cliente2.CuentaBancaria.Retirar(500);
cliente3.CuentaBancaria.Depositar(2500);
cliente3.CuentaBancaria.Retirar(700);

double dineroTotal = banco.CalcularDineroTotal();

Console.WriteLine($"Dinero total en el banco al final del dia: {dineroTotal:C}\n");