using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario___Cálculo_de_aumento_salarial
{
    internal class Funcionario
    {
            public string nome;
            public float salario;

            public float CalcularSalario()
            {
                Console.WriteLine("Qual a porcentagem do aumento do salário?");
                float valor = float.Parse(Console.ReadLine());

                float porcentagem = (valor / 100) + 1;
                this.salario = this.salario * porcentagem;

                Console.WriteLine("O novo salário é de " + salario);
                Console.ReadLine();

                return this.salario;
            }
    }
}
