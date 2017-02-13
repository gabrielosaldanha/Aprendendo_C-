using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de
            um link de Internet (em Mbps), calcule e informe o tempo aproximado de download do arquivo
            usando este link (em minutos).*/

            double tamanhoArquivo, velocidadeMBPS, velocidadeMBPM, tempoAproximado;
            string tmp;

            Console.WriteLine("Informe o tamanho do arquivo para download: ");
            tmp = Console.ReadLine();
            if (!double.TryParse(tmp, out tamanhoArquivo))
            {
                Console.WriteLine("Você informou corretamente o tamanho do arquivo para download?");
            }
            else
            {
                Console.WriteLine("Informe a velocidade da sua internet para downloads em MBps por segundos: ");
                tmp = Console.ReadLine();

                if (!double.TryParse(tmp, out velocidadeMBPS))
                {
                    Console.WriteLine("Você informou corretamente a velocidade da internet em MBps?");
                }
                else
                {
                    velocidadeMBPM = velocidadeMBPS * 60;
                    tempoAproximado = tamanhoArquivo / velocidadeMBPM;
                    Console.WriteLine("O tempo aproximado para fazer este download será de {0} minuto(s)", tempoAproximado);
                }

            }
        }
    }
}
