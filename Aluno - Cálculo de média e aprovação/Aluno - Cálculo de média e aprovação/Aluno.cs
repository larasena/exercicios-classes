using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno___Cálculo_de_média_e_aprovação
{
    internal class Aluno
    {
        public string nome;
        public double notaQuiz;
        public double notaProva;
        public double notaTrabalho;

        public double CalcularMedia()
        {
            string nome = this.nome;
            double media = (this.notaQuiz + this.notaProva + this.notaTrabalho) / 3;
            string mediaFormatada = media.ToString("N2");
            double.Parse(mediaFormatada);

            if (media > 6)
                Console.WriteLine("Parabéns {0}! Sua média foi de {1}, você foi aprovado(a)!", nome, mediaFormatada);

            else if (media < 4)
                Console.WriteLine("Que pena {0}, sua média foi de {1}. Você foi reprovado(a)!", nome, mediaFormatada);

            else
                Console.WriteLine("{0}, sua média foi de {1}. Você está de recuparação", nome, mediaFormatada);

            return media;
        }
    }
}
