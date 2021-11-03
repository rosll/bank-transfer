using System;
using Bank.Transfer.Classes;
using Bank.Transfer.Enum;

namespace Bank.Transfer
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Romulo Lima");
            
            Console.WriteLine(minhaConta.ToString());
        }
    }
}
