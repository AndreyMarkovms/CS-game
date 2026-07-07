using BattleEngine.Core.Enums;

namespace BattleEngine.Combat;

public class ResultadoAtaque
{
    public int SucessosAtk;
    public int SucessosLiq;
    public int SucessosDef;
    public int Mitigacao;
    public Boolean ContraAtaque;
    public Reacao Reacao;

    public ResultadoAtaque(Reacao Reacao)
    {
        SucessosAtk = 0;
        SucessosLiq = 0;
        SucessosDef = 0;
        Mitigacao = 0;
        ContraAtaque = 0;
        this.Reacao = Reacao;
        
    }
}