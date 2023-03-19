using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa___Construtor_e_método_de_impressão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Lara";
            p1.idade = 25;

            Pessoa p2 = new Pessoa();
            p2.nome = "Thalia";
            p2.idade = 7;

            Pessoa p3 = new Pessoa();
            p3.nome = "Luiz";
            p3.idade = 26;

            p1.ImprimirNomeEIdade();
            p2.ImprimirNomeEIdade();
            p3.ImprimirNomeEIdade();
                Console.ReadLine();
        }
    }
}
