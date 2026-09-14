using System.Diagnostics;
using BattleEngine.Characters;
using BattleEngine.Core.Enums;
using BattleEngine.Tests;

namespace BattleEngine.Weapons;

public abstract class Arma
{
    public string Nome {get;}
    
    public int DanoBase {get; }

    public int Dados {get; }

    public int Multiplicador {get; }

    public TipoAtributo Atributo {get; }

    public int CustoAcao {get; }
    protected Arma(string Nome, int DanoBase, int Dados, int Multiplicador, int CustoAcao)
    {
        this.Nome = Nome;
        this.DanoBase = DanoBase;
        this.Dados = Dados;
        this.Multiplicador = Multiplicador;
        this.CustoAcao = CustoAcao;
    }

    public abstract ResultadoTesteAtk Atacar(Personagem Atacante);
}