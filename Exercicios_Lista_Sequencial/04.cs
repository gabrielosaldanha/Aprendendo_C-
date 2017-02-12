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
            /*Faça um Programa que peça as 4 notas bimestrais e mostre a média.*/

            string frase = "Informe a {0} nota: ";
            float n1, n2, n3, n4;

            Console.Write(frase, "primeira");
            string tmp = Console.ReadLine();
            if (float.TryParse(tmp, out n1))
            {
                Console.Write(frase, "segunda");
                tmp = Console.ReadLine();
                if (float.TryParse(tmp, out n2))
                {
                    Console.Write(frase, "terceira");
                    tmp = Console.ReadLine();
                    if (float.TryParse(tmp, out n3))
                    {
                        Console.Write(frase, "quarta");
                        tmp = Console.ReadLine();
                        if (float.TryParse(tmp, out n4))
                        {
                            float media = (n1 + n2 + n3 + n4) / (4);
                            Console.WriteLine("A média deste aluno é de {0}", media);
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
