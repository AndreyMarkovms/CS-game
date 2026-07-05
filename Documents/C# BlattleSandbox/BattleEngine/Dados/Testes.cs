namespace BattleEngine.Tests;

using System.Security.Cryptography.X509Certificates;
using BattleEngine.Dice;
public class Testes
{
    public static ResultadoTeste Testar(int atributo)
    {
        ResultadoTeste resultado = new();
        resultado.DadosInicial(atributo);
        for(int i = 0; i < resultado.Rolagens; i++)
        {
            int d = Dados.D12();
            resultado.AdicionarDado(d);
        }
        return resultado;
    }
}