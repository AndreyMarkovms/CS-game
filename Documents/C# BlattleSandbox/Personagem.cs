public class Personagem
{
    public string Nome {get; private set; }

    public int HP {get; private set; }

    public int Hake {get; private set;}

    public Personagem(string Nome)          //Construtor
    {
        this.Nome = Nome;
        HP = 100;
        Hake = 100;
    }

    public void ReceberDano(int Dano)
    {
        HP = HP - Dano;
    }
}