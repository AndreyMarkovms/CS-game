using BattleEngine.Characters;
using BattleEngine.Dice;

List<Personagem> equipe = new();
Personagem mark = new Personagem("Mark");
equipe.Add(mark);
Personagem jade = new Personagem("Jade");
equipe.Add(jade);
Personagem denzel = new Personagem("Denzel");
equipe.Add(denzel);
Personagem spike = new Personagem("Spike");
equipe.Add(spike);

foreach(var Personagem in equipe)
{
    Console.WriteLine(Personagem.Nome);
}
