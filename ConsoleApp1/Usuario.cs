using System.Globalization;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    internal class Usuario
    {
        public int Conta { get; private set; }
        private string Nome { get; set; }
        public double Saldo { get; private set; }




        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.00; 
        }


        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }

        public Usuario(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }       

        public Usuario(int conta, string nome, double depositoInicial) : this(conta, nome)
        {
            Deposito(depositoInicial);  
        }


        public override string ToString()
        {
            return "Dados da Conta: "
                + Conta 
                +" , Titular: "
                + Nome
                +" Saldo: "
                +Saldo;
        }

    }
}
