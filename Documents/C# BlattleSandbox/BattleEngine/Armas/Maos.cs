using BattleEngine.Core.Enums;
using BattleEngine.Tests;
using BattleEngine.Characters;

namespace BattleEngine.Weapons;

public class Maos : Arma
{

    public Maos() : base("Maos", 1, 1, 1, 1)
    {}
    public override ResultadoTesteAtk Atacar(Personagem atacante)
    {
        ResultadoTesteAtk resultadoTesteAtk = new();
        resultadoTesteAtk.ResultadoTeste = Testes.Testar(atacante.Atributos.Obter(TipoAtributo.Forca) + atacante.Atributos.Obter(TipoAtributo.Agilidade));
        resultadoTesteAtk.DanoFinal = this.DanoBase + (resultadoTesteAtk.ResultadoTeste.Sucessos * Multiplicador);

        return resultadoTesteAtk;
    }
}