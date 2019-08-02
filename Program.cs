using System;
using System.Globalization;
namespace Exercicio61
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta:");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            char resp = char.ToUpper(char.Parse(Console.ReadLine()));
            if (resp == 'S')
            {
                Console.Write("Entre o valor inicial do depósito:");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, deposito);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito:");
            conta.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados.");
            Console.WriteLine(conta);
            Console.WriteLine();



            Console.Write("Entre um valor para saque:");
            conta.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados.");
            Console.WriteLine(conta);

        }
    }
}
