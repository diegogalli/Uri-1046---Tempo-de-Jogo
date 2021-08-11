using System;
using System.Globalization;

namespace TempoJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] DuracaoJogo = Console.ReadLine().Split(' ');

            int HoraInicio = int.Parse(DuracaoJogo[0]);
            int HoraFinal = int.Parse(DuracaoJogo[1]);

            int tempo;
            
            if ( HoraInicio < HoraFinal)
            {
                tempo = HoraFinal - HoraInicio;
            }
            else
            {
                tempo = 24 - HoraInicio + HoraFinal;
            }
            Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
            
        }
    }
}
