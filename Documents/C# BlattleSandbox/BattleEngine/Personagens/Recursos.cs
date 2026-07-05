namespace BattleEngine.Characters;
public class Recursos
{
    public int HP {get; private set; }
    public int HPMax {get; private set;}

    public int Heka {get; private set;}
    public int HekaMax {get; private set;}
    
    public int SP {get; private set;}
    
    public int SPMax{get; private set;}

    public Recursos(int HP, int Hake, int SP)
    {
        this.HP = HP;
        HPMax = HP;
        this.Heka = Heka;
        HekaMax = Heka;
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
        Console.WriteLine($"Heka : {Heka}/{HekaMax}");
    }

}