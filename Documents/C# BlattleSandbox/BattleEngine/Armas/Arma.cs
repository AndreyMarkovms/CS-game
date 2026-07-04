using BattleEngine.Core.Enums;

namespace BattleEngine.Weapons;

public abstract class Arma
{
    public string Nome {get;}
    
    public int DanoBase {get; }

    public int Dados {get; }

    public TipoAtributo Atributo {get; }

    protected Arma(string Nome, int DanoBase, int Dados, TipoAtributo Atributo)
    {
        this.Nome = Nome;
        this.DanoBase = DanoBase;
        this.Dados = Dados;
        this.Atributo = Atributo;
    }
}