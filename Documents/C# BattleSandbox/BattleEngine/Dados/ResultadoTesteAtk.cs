using BattleEngine.Weapons;

namespace BattleEngine.Tests;

public class ResultadoTesteAtk
{
    public ResultadoTeste ResultadoTeste {get; set; }
    public int DanoFinal {get; set; }

    public ResultadoTesteAtk()
    {
        int DanoFinal = 0;
        this.ResultadoTeste = new();
    }
}