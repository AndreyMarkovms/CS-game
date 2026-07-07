using BattleEngine.Core.Enums;

namespace BattleEngine.Characters;
̣// Métodos: Construtor, zerar valores, alterar estados de combate;
public class EstadoCombate
{
    public Reacao Reacao;

    public EstadoCombate()
    {
        this.Reacao = Reacao.Esquiva;
    }
}