using BattleEngine.Core.Enums;

namespace BattleEngine.Characters;

public class Atributos
{
public int Forca {get; private set;}
public int Agilidade {get; private set;}
public int Raciocinio {get; private set;}
public int Emocional {get; private set;}
public int Controle {get; private set;}
public int Estabilidade {get; private set;}

public int Obter(TipoAtributo atributo)
    {
        return atributo switch
        {
            TipoAtributo.Forca => this.Forca,
            TipoAtributo.Agilidade => this.Agilidade,
            TipoAtributo.Raciocinio => this.Raciocinio,
            TipoAtributo.Emocional => this.Emocional,
            TipoAtributo.Controle => this.Controle,
            TipoAtributo.Estabilidade => this.Estabilidade,
            _ => throw new ArgumentOutOfRangeException(nameof(atributo))
        };
    }
}