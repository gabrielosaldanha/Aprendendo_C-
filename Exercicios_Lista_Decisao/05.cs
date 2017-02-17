using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facilitadores;

namespace ed05
{
    class ed05
    {
        static void Main(string[] args)
        {
            /*
            Faça um programa para a leitura de duas notas parciais de um aluno.
            O programa deve calcular a média alcançada por aluno e apresentar:

            A mensagem "Aprovado", se a média alcançada for maior ou igual a sete;
            A mensagem "Reprovado", se a média for menor do que sete;
            A mensagem "Aprovado com Distinção", se a média for igual a dez
            */

            double numero1, numero2;
            string tmp, tmp2;
            bool validade, validade2;

            Console.Write("Informe a primeira nota: ");
            tmp = Console.ReadLine();

            Console.Write("Informe a primeira nota: ");
            tmp2 = Console.ReadLine();

            validade = Mark.VerificaNum(tmp);
            validade2 = Mark.VerificaNum(tmp2);

            if (validade && validade2 == true)
            {
                double.TryParse(tmp, out numero1);
                double.TryParse(tmp2, out numero2);

                double media = (numero1 + numero2) / 2;
                string status = " ";
                /*
                A mensagem "Aprovado", se a média alcançada for maior ou igual a sete;
                A mensagem "Reprovado", se a média for menor do que sete;
                A mensagem "Aprovado com Distinção", se a média for igual a dez
                */

                if (media == 10)
                {
                    status = "Aprovado com Distinção";
                }

                else if (media >= 7)
                {
                    status = "Aprovado";
                }
                else if (media < 7)
                {
                    status = "Reprovado";
                }

                Console.WriteLine("O aluno foi {0}", status);


             
            }

        }
    }
}
