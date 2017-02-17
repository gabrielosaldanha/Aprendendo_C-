using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facilitadores;

namespace ed07
{
    class ed07
    {
        static void Main(string[] args)
        {
            //Faça um Programa que leia três números e mostre o maior e o menor deles
            double numero1, numero2, numero3, maior, menor;
            string tmp, tmp2, tmp3;
            bool validade;

            Console.Write("Informe o primeiro número: ");
            tmp = Console.ReadLine();

            Console.Write("Informe o segundo número: ");
            tmp2 = Console.ReadLine();

            Console.Write("Informe o terceiro número: ");
            tmp3 = Console.ReadLine();

            validade = Mark.VerificaNum(tmp, tmp2, tmp3);
            if (!(validade == true))
            {
                Console.WriteLine("Você informou números corretamente?");
            }
            else
            {
                double.TryParse(tmp, out numero1);
                double.TryParse(tmp2, out numero2);
                double.TryParse(tmp3, out numero3);

                double[] numeros = new double[3] { numero1, numero2, numero3 };
                maior = numeros.Max();
                menor = numeros.Min();
                Console.WriteLine("O maior número é o {0}", maior);
                Console.WriteLine("O menor número é o {0}", menor);
            }
        }
    }
}
