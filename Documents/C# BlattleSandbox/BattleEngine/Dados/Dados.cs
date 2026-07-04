namespace BattleEngine.Dice;
public class Dados
{
    private static readonly Random gerador = new();
    public static int Dn(int n)
    {
        return gerador.Next(1, n+1);
    }

    public static int D20()
    {
        return Dn(20);
    }

    public static int D100()
    {
        return Dn(100);
    }
    
    public static int D6()
    {
        return Dn(6);
    }

    public static int D4()
    {
        return Dn(4);
    }
}