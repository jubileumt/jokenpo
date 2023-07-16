using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    internal class Game
    {
       public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        public static Image[] imagens =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Tesoura.png"),
            Image.FromFile("imagens/Papel.png")
        };

        public Image imgPC { get;private set; }
        public Image imgJogador { get;private set; }

        public Resultado Jogar(int Jogador)
        {
            int pc = JogadaPC();

            imgJogador = imagens[Jogador];
            imgPC = imagens[pc];

            if (Jogador == pc)
            {
                return Resultado.Empatar;
            }

            else if ((Jogador == 0 && pc == 1) || (Jogador == 1 && pc == 2)  || (Jogador == 2 && pc == 0))
            {
                return Resultado.Ganhar;
            }

            else
            {
                return Resultado.Perder;
            }
        }

        private int JogadaPC()
        {
            int mil = DateTime.Now.Millisecond;
            if (mil<333)
            {
                return 0;
            }

            else if (mil >= 333 && mil < 666)
            {
                return 1;
            }

            else 
            { 
                return 2;
            }

        }
    }
}
