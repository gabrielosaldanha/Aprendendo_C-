using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça um Programa para uma loja de tintas. O programa deverá pedir o tamanho em metros
            quadrados da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 6
            metros quadrados e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00 ou em
            galões de 3,6 litros, que custam R$ 25,00.
            Informe ao usuário as quantidades de tinta a serem compradas e os respectivos preços em
            3 situações:
            comprar apenas latas de 18 litros;
            comprar apenas galões de 3,6 litros;
            misturar latas e galões, de forma que o preço seja o menor. Acrescente 10% de folga e
            sempre arredonde os valores para cima, isto é, considere latas cheias.
             */

            double metrosQuadrados, cobertura, pLata = 80.00, litrosNecessarios,
                   capLata = 18.00, capGalao = 3.6, pGalao = 25.00;
            string tmp;

            Console.Write("Informe a área a ser pintada em metros quadrados: ");
            tmp = Console.ReadLine();

            if (!double.TryParse(tmp, out metrosQuadrados))
            {
                Console.WriteLine("Você informou corretamente a quantidade de área a ser pintada?");
            }
            else
            {
                metrosQuadrados += metrosQuadrados * 0.1;
                litrosNecessarios = metrosQuadrados / 6;
                apenasLatas(litrosNecessarios);
                apenasGaloes(litrosNecessarios);
                int Galoes = qntGaloesRetornavel(litrosNecessarios);
                latasGaloes(Galoes);
            }

        }

        public static int qntGaloesRetornavel(double litrosNecessarios, double capGalao = 3.6, double pGalao = 25.00)
        {
            double qntGaloes = litrosNecessarios / capGalao;

            if (qntGaloes > 1)
            {
                qntGaloes = (((Int32)qntGaloes) + 1);
                double totalPagar = pGalao * qntGaloes;
                int Galoes = Convert.ToInt32(qntGaloes);
                Galoes++;
                return Galoes;
            }
            else
            {
                return 0;
            }
        }

        public static void apenasLatas(double litrosNecessarios, double capLata = 18.00, double pLata = 80.00)
        {
            double qntLatas = litrosNecessarios / capLata;

            if (qntLatas <= 1)
            {
                Console.WriteLine("Você precisará comprar apenas 1 lata e isso irá custar R$ 80,00");
            }
            else if (qntLatas > 1)
            {
                qntLatas = (((Int32)qntLatas) + 1);
                double totalPagar = pLata * qntLatas;
                Console.WriteLine("Você precisará comprar {0} latas e isso irá custar R${1}", qntLatas, totalPagar);
            }
        }
        public static void apenasGaloes(double litrosNecessarios, double capGalao = 3.6, double pGalao = 25.00)
        {
            double qntGaloes = litrosNecessarios / capGalao;

            if (qntGaloes <= 1)
            {
                Console.WriteLine("Você precisará comprar apenas 1 galão e isso irá custar R$ 25,00");
            }
            else if (qntGaloes > 1)
            {
                qntGaloes = (((Int32)qntGaloes) + 1);
                double totalPagar = pGalao * qntGaloes;
                Console.WriteLine("Você precisará comprar {0} galões e isso irá custar R${1}", qntGaloes, totalPagar);
            }
        }
        public static void latasGaloes(int galoes)
        {
            int qntLatas = 0;
            while (galoes >= 5)
            {
                galoes -= 5;
                qntLatas += 1;
                

            }
            double pTotal = (galoes * 25) + (qntLatas * 80);
            Console.WriteLine("Para economizar deve-se comprar {0} latas e {1} galões, pagando o total de {2}", qntLatas, galoes, pTotal);
        }

    }
}
