using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facilitadores;

namespace ed08
{
    class ed08
    {
        static void Main(string[] args)
        {
            //Faça um programa que pergunte o preço de três produtos e informe qual produto você deve
            //comprar, sabendo que a decisão é sempre pelo mais barato.

            double produto1, produto2, produto3;
            string temp1, temp2, temp3;

            Console.Write("Informe o preço do primeiro produto: ");
            temp1 = Console.ReadLine();

            Console.Write("Informe o preço do segundo produto: ");
            temp2 = Console.ReadLine();

            Console.Write("Informe o preço do terceiro produto: ");
            temp3 = Console.ReadLine();



            bool validade = Mark.VerificaNum(temp1);
            bool validade2 = Mark.VerificaNum(temp2);
            bool validade3 = Mark.VerificaNum(temp3);

            if ((validade == true) && (validade2 == true) && (validade3 == true))
            {
                double.TryParse(temp1, out produto1);
                double.TryParse(temp2, out produto2);
                double.TryParse(temp3, out produto3);

                double[] produtos = new double[] { produto1, produto2, produto3 };
                double menorPreco = Mark.Menor(produtos);

                Console.WriteLine("Comprar o produto que custa R$ {0}", menorPreco);
            }
            else
            {
                Console.WriteLine("Você informou direito o preço dos produtos?");
            }
        }
    }
}
