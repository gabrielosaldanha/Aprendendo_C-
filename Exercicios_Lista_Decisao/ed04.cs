using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed04
{
    class ed04
    {
        static void Main(string[] args)
        {
            // Faça um Programa que verifique se uma letra digitada é vogal ou consoante.

            string[] vogais;
            string a = "a", e = "e", i = "i", o = "o", u = "u";
            vogais = new string[5] {a, e, i, o, u };
            Console.Write("Informe uma letra para verificar se é vogal: ");
            string letra = Console.ReadLine();
            if (vogais.Contains(letra))
            {
                Console.WriteLine("Você informou uma vogal!");
            }
            else
            {
                Console.WriteLine("Você informou uma consoante!");
            }



        }
    }
}
