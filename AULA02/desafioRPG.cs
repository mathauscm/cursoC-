using System;

class desafioRPG
{
    static void Main()
    {
        Random dice = new Random();

        int lifeMonster = 10;
        int lifeHero = 10;

        do
        {
            int atackHero = dice.Next(1, 11);
            lifeMonster -= atackHero;
            Console.WriteLine($"Monster was damaged and lost {atackHero} and now has {lifeMonster} health.");

            if (lifeMonster <= 0)
            {
                continue;  // Monstro foi derrotado, pula o ataque do monstro
            }

            int atackMonster = dice.Next(1, 11);
            lifeHero -= atackMonster;
            Console.WriteLine($"Hero was damaged and lost {atackMonster} and now has {lifeHero} health.");

        } while (lifeHero > 0 && lifeMonster > 0);

        Console.WriteLine(lifeHero > lifeMonster ? "Hero wins!" : "Monster wins!");
    }
}