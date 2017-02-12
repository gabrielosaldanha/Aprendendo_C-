using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo que calcule seu
            peso ideal, usando a seguinte fórmula: (72.7 * altura) - 58 */

            double altura, pesoIdeal;
            string tmp;

            Console.Write("Informe sua altura: ");
            tmp = Console.ReadLine();

            if (double.TryParse(tmp, out altura))
            {
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine("O peso ideal é {0}", pesoIdeal);
            }
            else
            {
                Console.WriteLine("Você digitou corretamente a altura?");
            }
        }   
    }
}
