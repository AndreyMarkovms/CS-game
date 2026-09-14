namespace BattleEngine.Tests;

public class ResultadoTeste
{
    public int Sucessos {get; private set;}
    public int Explosoes {get; private set;}
    public int Falhas {get; private set;}
    public int Rolagens {get; private set;}
    public List<int> Valores {get; } = new();

    public ResultadoTeste()
    {
        Sucessos = 0;
        Explosoes = 0;
        Falhas = 0;
        Rolagens = 0;
    }

    public void AdicionarDado(int d)
    {
        this.Valores.Add(d);
        if (d >= 8)
        {
            this.Sucessos += 1;
        }
        if (d == 12)
        {
            this.Explosoes += 1;
            this.Rolagens += 1;
        }
        if (d < 8)
        {
            this.Falhas += 1;
        }
    }

    public void DadosInicial(int atributo)
    {
        this.Rolagens = atributo;
    }
}