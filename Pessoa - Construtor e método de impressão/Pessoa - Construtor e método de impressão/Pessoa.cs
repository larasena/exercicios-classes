using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa___Construtor_e_método_de_impressão
{
    internal class Pessoa
    {
        public string nome;
        public int idade;

        public void ImprimirNomeEIdade()
        {
            Console.WriteLine($"{nome}, {idade}");
        }
    }
}
