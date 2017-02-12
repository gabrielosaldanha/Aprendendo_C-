using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um Programa que pergunte quanto você ganha por hora
              e o número de horas trabalhadas no mês. 
              Calcule e mostre o total do seu salário no referido mês.*/

            double valorH, horasT;

            //Recebimento de dados
            Console.Write("Informe a quantidade de horas trabalhadas neste mês: ");
            string temp = Console.ReadLine();

            if (double.TryParse(temp, out valorH))
            {
                Console.Write("Informe o valor de cada hora a ser pago: ");
                temp = Console.ReadLine();

                if (double.TryParse(temp, out horasT))
                {
                    double salario = valorH * horasT;
                    Console.WriteLine("Seu salário este mês será de R$ {0}", salario);
                }
                else
                {
                    Console.WriteLine("Você digitou corretamente?");
                }
            }
            else
            {
                Console.WriteLine("Você digitou corretamente?");
            }
        }
    }
}
