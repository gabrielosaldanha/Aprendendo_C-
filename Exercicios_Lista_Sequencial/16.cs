using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros
            quadrados da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3
            metros quadrados e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. Informe ao
            usuário a quantidades de latas de tinta a serem compradas e o preço total.*/

            double metrosQuadrados, litrosNecessarios, pLata = 80.00, qntLatas, totalPagar;

            Console.WriteLine("Informe em metros quadrados a área a ser pintada: ");
            string tmp = Console.ReadLine();
            
            if (double.TryParse(tmp, out metrosQuadrados))
            {
                litrosNecessarios = metrosQuadrados / 3;
                qntLatas = litrosNecessarios / 18;
                
                if (qntLatas <= 1)
                {
                    Console.WriteLine("Você precisará comprar apenas 1 lata e isso irá custar R$ 80,00");
                }
                else if (qntLatas > 1)
                {
                    qntLatas = (((Int32)qntLatas) + 1);
                    totalPagar = pLata * qntLatas;
                    Console.WriteLine("Você precisará comprar {0} latas e isso irá custar R${1}", qntLatas, totalPagar);
                }
            }
            else
            {
                Console.WriteLine("Você digitou corretamente os metros quadrados?");
            } 

        }
    }
}
