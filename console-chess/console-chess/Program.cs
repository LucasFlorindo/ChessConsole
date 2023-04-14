using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using console_chess.tabuleiro;
using xadrez;
using tabuleiro;
using console_chess.xadrez;

namespace console_chess
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                Tela.imprimirTabuleiro(partida.tab);
            }catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.ReadLine();


        }
    }
}
