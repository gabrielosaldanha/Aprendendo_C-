using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed02
{
    class ed02
    {
        static void Main(string[] args)
        {
            /*Faça um Programa que peça um número e então mostre a mensagem O número informado foi [número].*/

            float numero;
            Console.Write("Digite um número: ");
            string tmp = Console.ReadLine();
            if (float.TryParse(tmp, out numero))
            {
                Console.WriteLine("O número digitado foi: {0}", numero);
            }
            else
            {
                Console.WriteLine("Você digitou um número?");
            }
        }
    }
}
