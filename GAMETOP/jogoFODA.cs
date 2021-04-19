using System;
using GameTOP.Interface;

namespace GAMETOP
{
    public class JogoFODA
    {
        private readonly iJogador jogador;

        private readonly iJogador jogador2;

        public JogoFODA(iJogador jogador, iJogador jogador2)
        {
            this.jogador = jogador;
            this.jogador2 = jogador2;
        }
        public void IniciarJogo(){
                Console.Write(jogador.Corre());
                Console.Write(jogador.Chuta());
                Console.Write(jogador.Passa());

                Console.Write("\n\n PRÓXIMO JOGADOR \n\n");

                Console.Write(jogador2.Corre());
                Console.Write(jogador2.Chuta());
                Console.Write(jogador2.Passa());

        }
    }
}

