using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed03
{
    class ed03
    {
        static void Main(string[] args)
        {
            /*3. Faça um Programa que peça dois números e imprima a soma*/

            float numero1, numero2;
            Console.Write("Digite o primeiro número: ");
            string tmp = Console.ReadLine();
            if (float.TryParse(tmp, out numero1))
            {
                Console.Write("Digite o segundo número: ");
                tmp = Console.ReadLine();
                if (float.TryParse(tmp, out numero2))
                {
                    Console.WriteLine("A soma entre {0} e {1} equivale a {2}", numero1, numero2, (numero1+numero2));
                }

            }
            else
            {
                Console.WriteLine("Você tem certeza que digitou um número?");
            }

        }
    }
}
