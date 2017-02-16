using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um Programa que peça dois números e imprima o maior deles

            double numero1, numero2;
            Console.WriteLine("Informe um número: ");
            string tmp = Console.ReadLine();
            if (!double.TryParse(tmp, out numero1))
            {
                Console.WriteLine("Você digitou corretamente um número?");
            }
            else
            {
                Console.WriteLine("Informe um número: ");
                tmp = Console.ReadLine();

                if (!double.TryParse(tmp, out numero2))
                {
                    Console.WriteLine("Você digitou corretamente um número?");
                }
                else
                {
                    if (numero1 > numero2)
                    {
                        Console.WriteLine("O número {0} é maior", numero1);
                    }
                    else
                    {
                        Console.WriteLine("O número {0} é maior", numero2);
                    }
                }
            }
            

        }
    }
}
