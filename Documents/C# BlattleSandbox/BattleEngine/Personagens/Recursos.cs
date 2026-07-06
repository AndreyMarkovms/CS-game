namespace BattleEngine.Characters;
public class Recursos
{
    public int HP {get; private set; }
    public int HPMax {get; private set; }

    public int AP {get; private set; }    
    public int SP {get; private set; }
    
    public int SPMax{get; private set; }

    public int FluxoHeka{get; private set; }

    public Recursos(int HP, int Heke, int SP)
    {
        this.HP = HP;
        this.HPMax = HP;
        this.SP = SP;
        this.SPMax = SP;
        this.FluxoHeka = 0;
        this.AP = 3;
    }

    public void AlterarHP(int Valor)
    {
        this.HP = this.HP + Valor;
        if (this.HP < 0)
        {
            this.HP = 0;
        }
        if (this.HP > this.HPMax)
        {
            this.HP = this.HPMax;
        }
    }
    public void AlterarSP(int Valor)
    {
        this.SP = this.SP + Valor;
        if (this.SP > this.SPMax)
        {
            this.SP = this.SPMax;
        }
        if (this.SP < 0)
        {
            this.SP = 0;
        }
    }

    public void AlterarFluxo(int Valor)
    {
        this.FluxoHeka = this.FluxoHeka + Valor;
        if (this.FluxoHeka > 10)
        {
            this.FluxoHeka = 10;
        }
        if (this.FluxoHeka < 0)
        {
            this.FluxoHeka = 0;
        }
    }
}