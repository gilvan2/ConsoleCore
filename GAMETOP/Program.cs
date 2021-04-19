﻿using System;
using GameTOP.Lib;

namespace GAMETOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                new Jogador1(), 
                new Jogador2()
            );
            jogo.IniciarJogo();
        }
    }
}

