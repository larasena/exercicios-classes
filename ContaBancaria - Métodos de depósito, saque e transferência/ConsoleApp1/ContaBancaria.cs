using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ContaBancaria
    {
        public string nome;
        public int numeroDaConta;
        public float saldo;

        public void DadosDaConta()
        {
            Console.WriteLine($"Titular: {this.nome}, Conta: {this.numeroDaConta}, Saldo: {this.saldo}");
        }

        public float Deposito(float valor)
        {
            this.saldo += valor;
            return saldo;
        }

        public float Saque(float valor)
        {
            if (valor > this.saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return this.saldo;
            }


            else
            {
                this.saldo -= valor;
                return saldo;
            }
        }

        
        public bool Transferencia(ContaBancaria contaDestino, float valor)
        {
            if(valor > this.saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.saldo += valor;
                return true;
            }
        }
    }
}
