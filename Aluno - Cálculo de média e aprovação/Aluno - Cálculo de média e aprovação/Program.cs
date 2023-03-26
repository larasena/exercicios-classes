using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno___Cálculo_de_média_e_aprovação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.nome = "Thalia";
            a1.notaQuiz = 10.0;
            a1.notaProva = 6.4;
            a1.notaTrabalho = 7.2;

            Aluno a2 = new Aluno();
            a2.nome = "Luiz";
            a2.notaQuiz = 6.0;
            a2.notaProva = 4.8;
            a2.notaTrabalho = 5.1;

            Aluno a3 = new Aluno();
            a3.nome = "Romeu";
            a3.notaQuiz = 3.6;
            a3.notaProva = 4.1;
            a3.notaTrabalho = 3.9;

            a1.CalcularMedia();
            a2.CalcularMedia();
            a3.CalcularMedia();
            Console.ReadLine();
        }
    }
}
