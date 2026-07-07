namespace BattleEngine.Combat;

using System.Diagnostics;
using BattleEngine.Characters;
using BattleEngine.Tests;

public class Combate
{
    public static ResultadoAtaque atacar(Personagem atk, Personagem def)
    {
        ResultadoAtaque resultadoAtaque = new(def.EstadoCombate.Reacao);
        
    }
}