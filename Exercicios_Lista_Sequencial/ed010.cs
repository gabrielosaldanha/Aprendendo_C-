using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um Programa que peça a temperatura em graus Celsius,
            transforme e mostre em graus Farenheit.*/

            double tempF, tempC;
            string temp;

            Console.Write("Informe a temperatura em Celsius: ");
            temp = Console.ReadLine();

            if (double.TryParse(temp, out tempC))
            {
                tempF = ((tempC + 32) * 1.8);
                Console.WriteLine("A temperatura em Farenheit é: {0}", tempF);
            }
            else
            {
                Console.WriteLine("Você digitou corretamente?");
            }
            
        }
    }
}
