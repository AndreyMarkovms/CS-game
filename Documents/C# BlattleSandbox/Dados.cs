public class Dados
{
    public static int dn(int n)
    {
        Random gerador = new Random();
        return gerador.Next(1, n+1);
    }

    public static int d20()
    {
        return dn(20);
    }

    public static int d100()
    {
        return dn(100);
    }
    
    public static int d6()
    {
        return dn(6);
    }

    public static int d4()
    {
        return dn(4);
    }
}