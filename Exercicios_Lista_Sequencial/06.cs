using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um Programa que peça o raio de um círculo, calcule e mostre sua área.*/

            double pi = 3.14;
            double raio;
            
            Console.Write("Informe o raio do circulo: ");
            string tmp = Console.ReadLine();

            if (double.TryParse(tmp, out raio))
            {
                double area = (pi * (Math.Pow(raio, 2.0)));
                Console.WriteLine("A área do circulo informado de raio {0} é equivalente a {1}", raio, area);
            }
            else
            {
                Console.WriteLine("Você digitou corretamente o raio do circulo?");
            }

        }
    }
}
