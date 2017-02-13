using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. 
             Calcule e mostre o total do seu salário no referido mês, sabendo-se que são descontados 11% para o 
             Imposto de Renda, 8% para o INSS e 5% para o sindicato, faça um programa que nos dê:
                salário bruto.
                quanto pagou ao INSS.
                quanto pagou ao sindicato.
                o salário líquido.
                calcule os descontos e o salário líquido, conforme a tabela abaixo:
                + Salário Bruto : R$
                - IR (11%) : R$
                - INSS (8%) : R$
                - Sindicato ( 5%) : R$
                = Salário Liquido : R$
             */

            double valorHora, horasT, salario, ir = 0.11, inss = 0.08, sindicato = 0.05, salarioLiquido, totalDesc;
                        
            string[] saida = { "+ Salário Bruto: R${0}", "-IR(11 %) : R${0}", "-INSS(8 %) : R${0}",
                                  "-Sindicato(5 %) : R${0}", "= Salário Liquido: R${0}" };

            Console.Write("Informe quanto você recebe por hora: ");
            string tmp = Console.ReadLine();

            if (double.TryParse(tmp, out valorHora))
            {
                Console.Write("Informe quantas horas você trabalhour esse mês: ");
                tmp = Console.ReadLine();

                if (double.TryParse(tmp, out horasT))
                {
                    salario = horasT * valorHora;

                    totalDesc = ((salario * ir) + (salario * inss) + (salario * sindicato));
                    salarioLiquido = salario - totalDesc;
                    Console.WriteLine(saida[0], salario);
                    Console.WriteLine(saida[1], (salario * ir));
                    Console.WriteLine(saida[2], (salario * inss));
                    Console.WriteLine(saida[3], (salario * sindicato));
                    Console.WriteLine(saida[4], salarioLiquido);
                }
                else
                {
                    Console.WriteLine("Você digitou corretamente as horas trabalhadas neste mês?");
                }

            }
            else
            {
                Console.WriteLine("Você digitou corretamente o valor que você recebe por hora?");
            }
        }
    }
}
