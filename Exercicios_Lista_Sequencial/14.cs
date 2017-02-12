using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             João Papo-de-Pescador, homem de bem, comprou um microcomputador para controlar o
rendimento diário de seu trabalho. Toda vez que ele traz um peso de peixes maior que o
estabelecido pelo regulamento de pesca do estado de São Paulo (50 quilos) deve pagar uma
multa de R$ 4,00 por quilo excedente. João precisa que você faça um programa que leia a
variável peso (peso de peixes) e verifique se há excesso. Se houver, gravar na variável excesso e
na variável multa o valor da multa que João deverá pagar. Caso contrário mostrar tais variáveis
com o conteúdo ZERO.
            */

            //regulamento de pesca 50 kg
            //multa por kg a mais = R$ 4.00
            //verificar se passou do peso
            //se não passou, tranquilo. mostrar como 0
            //se passou, calcular o valor da multa a ser paga no dia 

            double peixeKG;
            double multa;
            string tmp;

            Console.Write("Informe o valor em KG dos peixes pescados hoje: ");
            tmp = Console.ReadLine();

            if (Double.TryParse(tmp, out peixeKG))
            {
                if (peixeKG <= 50)
                {
                    Console.WriteLine("O senhor não pagará nenhuma multa de pesca!");
                }
                else
                {
                    multa = (peixeKG - 50) * 4.00;
                    double passado = peixeKG - 50;
                    Console.WriteLine("O senhor passou {0}kg do peso e pagará R$ {1} de multa", passado, multa);
                }
                    
            }
            else
            {
                Console.WriteLine("Você digitou corretamente?");
            }

        }
    }
}
