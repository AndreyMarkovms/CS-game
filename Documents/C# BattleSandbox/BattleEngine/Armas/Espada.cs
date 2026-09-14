using BattleEngine.Characters;
using BattleEngine.Core.Enums;
using BattleEngine.Tests;

namespace BattleEngine.Weapons;

public class Espada : Arma
{
    public Espada() : base("Espada", 1, 1, 1, 1)
    {}

    public override ResultadoTesteAtk Atacar(Personagem atacante)
    {
        ResultadoTesteAtk resultadoTesteAtk = new();
        resultadoTesteAtk.ResultadoTeste = Testes.Testar(atacante.Atributos.Obter(TipoAtributo.Forca) + this.Dados);
        resultadoTesteAtk.DanoFinal = this.DanoBase + (resultadoTesteAtk.ResultadoTeste.Sucessos * Multiplicador);

        return resultadoTesteAtk;
    }
}
