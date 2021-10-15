using System;

namespace ConsoleMyBankApp
{
	class Program
	{
		static void Main(string[] args)
			
		{
			Cliente cliente = new Cliente("Bruno Santana Lopes","000.004.444-52","Desenvolvedor");//Design pattern factor


			ContaCorrente conta = new ContaCorrente(cliente, 01, 0001);


			Console.WriteLine("Conta Corrente Criada:\n");

			Console.WriteLine("Titular: {0}", conta.getTitular().getNome());
			Console.WriteLine("Agencia: {0}", conta.getAgencia());
			Console.WriteLine("Conta: {0}", conta.getConta());

			Console.WriteLine("Parabéns! Seu saldo atual é de R${0}. Agradecemos a preferência!", conta.getSaldo());

			double valorDeposito = 200;

			conta.Depositar(valorDeposito);

			Console.WriteLine("\nVoce depositou R${0}", valorDeposito);
			Console.WriteLine("\nSeu saldo agora é R${0}!", conta.getSaldo());

			double valorSaque = 100;
			conta.Sacar(valorSaque);

			Console.WriteLine("\nSeu saldo após o saque é de R${0}.", conta.getSaldo());

			//NOVA-CONTA
			Cliente clienteSabrina = new Cliente("Sabrina Kopehagen", "000.000.444-52", "Cantora");
			ContaCorrente contaSabrina = new ContaCorrente(clienteSabrina, 01, 0002);

			double valorPix = 150;
			conta.Pix(valorPix, contaSabrina);

			Console.WriteLine("\nSeu saldo é de R${0}!", conta.getSaldo());
			Console.WriteLine("\nO saldo da conta da {1} é de R${0}!", contaSabrina.getSaldo(), contaSabrina.getTitular().getNome());


		}
	}
}
