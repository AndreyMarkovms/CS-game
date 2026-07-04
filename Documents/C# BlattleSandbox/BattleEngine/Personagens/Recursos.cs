namespace BattleEngine.Characters;
public class Recursos
{
    public int HP {get; private set; }
    public int HPMax {get; private set;}

    public int Hake {get; private set;}
    public int HakeMax {get; private set;}
    
    public int SP {get; private set;}
    
    public int SPMax{get; private set;}

    public Recursos(int HP, int Hake, int SP)
    {
        this.HP = HP;
        HPMax = HP;
        this.Hake = Hake;
        HakeMax = Hake;
        this.SP = SP;
        SPMax = SP;
    }

    public void TomaDanoHP(int Dano)
    {
        HP = HP - Dano;
    }

    public void TomaDanoSP(int Dano)
    {
        SP = SP - Dano;
    }

    public void Status()
    {
        Console.WriteLine($"HP : {HP}/{HPMax}");
        Console.WriteLine($"SP : {HP}/{HPMax}");
        Console.WriteLine($"HP : {HP}/{HPMax}");
    }

}