using ConsoleApp1;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Curso
{
    class Exercicio
    {
        static void Main(string[] args)
        {

            Usuario titular;

            Console.Write("Digite o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n) ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Digite o valor do deposito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                titular = new Usuario(conta, nome, deposito);
            }
            else
            {
                titular = new Usuario(conta, nome);
                
            }

            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(titular);

            Console.WriteLine();
            Console.WriteLine("Digite um valor pra deposito");
            double quantia = double.Parse(Console.ReadLine());
            titular.Deposito(quantia);
            Console.WriteLine(titular);

            Console.WriteLine();
            Console.WriteLine("Digite um valor pra saque");
            quantia = double.Parse(Console.ReadLine());
            titular.Saque(quantia);
            Console.WriteLine(titular);
        }
    }
}