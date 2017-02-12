using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça um Programa que peça 2 números inteiros e um número real. Calcule e mostre:
            a. o produto do dobro do primeiro com metade do segundo .
            b. a soma do triplo do primeiro com o terceiro.
            c. o terceiro elevado ao cubo.
            */

            int num1, num2;
            float real;
            string tmp;

            Console.Write("Informe um número inteiro: ");
            tmp = Console.ReadLine();

            if (int.TryParse(tmp, out num1))
            {
                Console.Write("Informe outro inteiro: ");
                tmp = Console.ReadLine();

                if (int.TryParse(tmp, out num2))
                {
                    Console.Write("Informe outro inteiro: ");
                    tmp = Console.ReadLine();

                    if (float.TryParse(tmp, out real))
                    {
                        int a = (num1 * (num2 / 2));
                        double b = ((num1 * 3) + real);
                        double c = (Math.Pow(real, 3));

                        Console.WriteLine("Respostas: A: {0} | B: {1} | C: {2}", a, b, c); 
                    }
                    else
                    {
                        Console.WriteLine("Você digitou corretamente um número real?");
                    }

                }
                else
                {
                    Console.WriteLine("Você digitou corretamente um inteiro?");
                }

            }
            else
            {
                Console.WriteLine("Você digitou corretamente um inteiro?");
            }
        }
    }
}
