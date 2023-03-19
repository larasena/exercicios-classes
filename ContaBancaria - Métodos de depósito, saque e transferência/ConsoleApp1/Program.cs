using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb1 = new ContaBancaria();
            cb1.nome = "Lara Sena";
            cb1.numeroDaConta = 0001;
            cb1.saldo = 2000.00f;

            ContaBancaria cb2 = new ContaBancaria();
            cb2.nome = "Thalia Maia";
            cb2.numeroDaConta = 0002;
            cb2.saldo = 5000.00f;

            
            cb1.Deposito(2000.00f);
            cb1.Saque(500.00f);
            cb1.Transferencia(cb2, 200.00f);
            cb1.DadosDaConta();

            cb2.Deposito(250.00f);
            cb2.Saque(100.00f);
            cb2.DadosDaConta();
            Console.ReadLine();

        }
    }
}
