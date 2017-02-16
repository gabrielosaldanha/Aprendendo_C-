using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facilitadores;


namespace ed03
{
    class ed03
    {
        static void Main(string[] args)
        {
            //Faça um Programa que verifique se uma letra digitada é "F" ou "M".
            //Conforme a letra escrever: F - Feminino, M - Masculino, Sexo Inválido.

            Console.WriteLine("Informe uma letra:");
            Console.WriteLine("[F] para Feminino - [M] para Masculino: ");
            Console.Write(">>> ");
            string sexo = Console.ReadLine();
            if (sexo == "f" || sexo == "F")
            {
                Console.WriteLine("Você informou Feminino");
            }
            else if (sexo == "m" || sexo == "M")
            {
                Console.WriteLine("Você informou Masculino");
            }
            else
            {
                Console.WriteLine("Você informou um sexo não definido");
            }


        }
    }
}

