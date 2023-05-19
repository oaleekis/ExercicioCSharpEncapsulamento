using System.Drawing;
using System.Globalization;

namespace ExercicioCSharpEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;

            Console.WriteLine("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)?");
            char opcao = char.Parse(Console.ReadLine());

            if (opcao == 's' || opcao == 'S')
            {
                Console.WriteLine("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroConta, nomeTitular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, nomeTitular);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine("Entre um valor para depósito: ");
            conta.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine($"Dados da conta atualizados: \n{conta}");


            Console.WriteLine("Entre um valor para saque:");
            conta.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine($"Dados da conta atualizados: \n{conta}");

        }
    }
}