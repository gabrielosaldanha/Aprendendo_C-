using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um algoritmo que
            calcule seu peso ideal, utilizando as seguintes fórmulas:
            a.Para homens: (72.7 * h) - 58
            b.Para mulheres: (62.1 * h) - 44.7(h = altura)
            c.Peça o peso da pessoa e informe se ela está dentro, acima ou abaixo do peso.
             */

            //Variaveis
            string sexo, alturaS;
            double altura, pesoIdeal, pesoAtual;


            //Start
            Console.Write("Informe sua altura: ");
            alturaS = Console.ReadLine();

            string pesoTmp;
            

            Console.Write("Informe seu sexo. [M] para masculino [F] para feminino: ");
            sexo= Console.ReadLine();
            sexo = sexo.ToLower();
            if (sexo == "m")
            {
                //Bloco de código para Masculino - (72.7 * h) - 58
                if (Double.TryParse(alturaS, out altura))
                {
                    pesoIdeal = (72.7 * altura) - 58;
                    Console.Write("Qual o seu peso: ");
                    pesoTmp = Console.ReadLine();
                    if (Double.TryParse(pesoTmp, out pesoAtual))
                    {
                        if (pesoAtual > pesoIdeal)
                        {
                            Console.WriteLine("Você está acima do peso. Seu peso ideal é {0}kg", pesoIdeal);
                        }
                        else
                            Console.WriteLine("VocÊ está dentro do seu peso ideal!");
                    }
                    else
                    {
                        Console.WriteLine("Você digitou corretamente seu peso?");
                    }
                }
                else
                {
                    Console.WriteLine("Você digitou corretamente a sua altura?");
                }
            }
            else if (sexo == "f")
            {
                if (Double.TryParse(alturaS, out altura))
                {
                    pesoIdeal = (62.1 * altura) - 44.7;
                    Console.Write("Qual o seu peso: ");
                    pesoTmp = Console.ReadLine();
                    if (Double.TryParse(pesoTmp, out pesoAtual))
                    {
                        if (pesoAtual > pesoIdeal)
                        {
                            Console.WriteLine("Você está acima do peso. Seu peso ideal é {0}kg", pesoIdeal);
                        }
                        else
                            Console.WriteLine("Você está dentro do seu peso ideal!");
                    }
                    else
                    {
                        Console.WriteLine("Você digitou corretamente seu peso?");
                    }
                }
                else
                {
                    Console.WriteLine("Você digitou corretamente a sua altura?");
                }
            }
            else
            {
                Console.WriteLine("Você digitou corretamente o sexo?");
            }
            
        }
    }
}
