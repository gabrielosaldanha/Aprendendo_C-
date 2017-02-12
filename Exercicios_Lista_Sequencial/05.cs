using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed05
{
    class ed05
    {
        static void Main(string[] args)
        {
            /* Faça um Programa que converta metros para centímetros.*/

            float metros;

            Console.Write("Informe o número de metros a ser convertido: ");
            string tmp = Console.ReadLine();
            if (float.TryParse(tmp, out metros))
            {
                float cm = metros * 100;
                Console.WriteLine("O número de centimetros é {0}", cm);
            }
            else
            {
                Console.WriteLine("Você digitou um número?");
            }
        }
    }
}
