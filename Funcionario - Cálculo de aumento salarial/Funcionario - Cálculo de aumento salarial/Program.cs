using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario___Cálculo_de_aumento_salarial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            f1.nome = "Lara";
            f1.salario = 2500.00f;

            f1.CalcularSalario();
        }
    }
}
