using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradorna estas pateando \n";
        }

        public string Corre()
        {
            return "Maradorna estas corriendo \n";
        }

        public string Passa()
        {
            return "Maradorna estas pasando \n";
        }
    }
}