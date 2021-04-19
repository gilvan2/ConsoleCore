using GameTOP.Interface;

namespace GameTOP.Lib
{
public class Jogador1 : iJogador
{
    public readonly string Nome;

    public Jogador1(string nome = "Ronaldo")
    {
        Nome = nome;
    }

    //Chuta
    public string Chuta()
    {
        return $"{Nome} está Chutando \n";
    }
    //Corre
    public string Corre()
    {
        return $"{Nome} está Correndo \n";
    }
    //Passa
    public string Passa()
    {
        return $"{Nome} está Passando";
    }
    
}
}