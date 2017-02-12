using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um Programa que calcule a área de um quadrado,
            em seguida mostre o dobro desta área para o usuário*/

            float lado;

            Console.Write("Informe um dos lados do quadrado: ");
            string tmp = Console.ReadLine();

            if (float.TryParse(tmp, out lado))
            {
                lado *= 4;
                lado *= 2;
                Console.WriteLine("O dobro da área deste quadrado é: {0}", lado);
            }
            else
            {
                Console.WriteLine("Você digitou corretamente o lado?");
            }

        }
    }
}
