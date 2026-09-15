namespace BattleEngine.Combat;

using System.Diagnostics;
using BattleEngine.Characters;
using BattleEngine.Tests;

public class Combate
{
    public static ResultadoAtaque Atacar(Personagem atk, Personagem def)
    {
        ResultadoAtaque resultadoAtaque = new(def.EstadoCombate.Reacao);
        


        return resultadoAtaque;
    }
}