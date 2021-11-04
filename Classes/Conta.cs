using System;
using Bank.Transfer.Enum;

namespace Bank.Transfer.Classes
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            TipoConta = tipoConta;
            Saldo = saldo;
            Credito = credito;
            Nome = nome;
        }

        public bool Sacar(double valorSaque)
        {
            if (Saldo - valorSaque < (Credito * -1)) //validação de saldo
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }

            Saldo -= valorSaque;
            Console.WriteLine($"Saldo atual da conta de {Nome} é {Saldo}");
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            Saldo += valorDeposito;
            Console.WriteLine($"Saldo atual da conta de {Nome} é {Saldo}");
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += $"Tipo Conta {TipoConta}" + " | ";
            retorno += $"Nome {Nome}" + " | ";
            retorno += $"Saldo ${Saldo}" + " | ";
            retorno += $"Crédito ${Credito}";
            return retorno;
        }
    }
}