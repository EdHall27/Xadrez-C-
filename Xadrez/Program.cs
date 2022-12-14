﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocaPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
            tab.colocaPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
            tab.colocaPeca(new Rei(Cor.Preta, tab), new Posicao(2, 4));

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
