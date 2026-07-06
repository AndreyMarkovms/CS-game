using BattleEngine.Dice;
using BattleEngine.Weapons;

namespace BattleEngine.Characters;
public class Personagem
{
    public string Nome {get; private set; }

    public Recursos Recursos {get; private set; }

    public Arma Arma {get; private set; }

    public Atributos Atributos {get; private set; }

    public Personagem(string Nome)          //Construtor
    {
        this.Nome = Nome;
        this.Recursos = new Recursos(100,100,100);
        this.Arma = new Maos();
        this.Atributos = new();
    }

    public void DanoHP(int Dano)
    {
        Recursos.AlterarHP((-1) * Dano);
    }

    public void DanoSP(int Dano)
    {
        Recursos.AlterarSP((-1) * Dano);
    }

    public void CuraHP(int Cura)
    {
        Recursos.AlterarHP(Cura);
    }

    public void CuraSP(int Cura)
    {
        Recursos.AlterarSP(Cura);
    }

    public void AumentaHeka(int aumento)
    {
        Recursos.AlterarFluxo(aumento);
    }

    public void ReduzirHeka(int reducao)
    {
        Recursos.AlterarFluxo((-1)*reducao);
    }
}