using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facilitadores;

namespace ed02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um Programa que peça um valor e mostre na tela se o valor é positivo ou negativo

            double numero1;
            string tmp; 
            Console.Write("Informe um número: ");
            tmp = Console.ReadLine(); 
            bool validade = Mark.VerificaNum(tmp);
            if (validade == true)
            {
                double.TryParse(tmp, out numero1);
                bool par = numero1 % 2 == 0;
                if (par == true)
                {
                    Console.WriteLine("O número é par");
                }
                else
                {
                    Console.WriteLine("O número é impar");
                }

            }
            else
            {
                Console.WriteLine("Você informou corretamente um número?");
            }
        }
    }
}
