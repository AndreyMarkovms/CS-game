using BattleEngine.Dice;
using BattleEngine.Weapons;

namespace BattleEngine.Characters;
public class Personagem
{
    public string Nome {get; private set; }

    public Recursos Recursos {get; private set; }
    public Arma Arma {get; private set;}

    public Personagem(string Nome)          //Construtor
    {
        this.Nome = Nome;
        this.Recursos = new Recursos(100,100,100);
        this.Arma = new Espada();
    }

    public void ReceberDanoHP(int Dano)
    {
        Recursos.TomaDanoHP(Dano);
    }

    public void ReceberDanoSP(int Dano)
    {
        Recursos.TomaDanoSP(Dano);
    }

    public void Status()
    {
        Console.WriteLine($"{Nome}:");
        Recursos.Status();
    }
}