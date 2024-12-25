using System;

class aula06
{
    static void Main()
    {
        Random dice = new Random();
        int tentativas = 0;
        int Pontuação = 0;
        int bonuspoint = 0;
        int total = 0;
        bool venceu = false;

        while (tentativas < 10 && !venceu)
        {
            Console.WriteLine("Digite um valor para os dados:");
            int entrada = Int32.Parse(Console.ReadLine());

            tentativas++;

            int dado1 = dice.Next(1, 7);
            int dado2 = dice.Next(1, 7);
            int dado3 = dice.Next(1, 7);
            total = dado1 + dado2 + dado3;

            Console.WriteLine($"Tentativa {tentativas}: Dados: {dado1}, {dado2}, {dado3} - Total: {total}");

            if (entrada == total || total >= 15)
            {
                Console.WriteLine("Parabéns você venceu!");
                venceu = true;
            }
            else
            {
                if ((dado1 == dado2) && (dado3 == dado1))
                {
                    bonuspoint += 3;
                }
                else if ((dado1 == dado2) || (dado1 == dado3) || (dado2 == dado3))
                {
                    bonuspoint += 2;
                }
            }
        }

        Console.WriteLine("Fim das tentativas. Total de tentativas: " + tentativas);
        int totalpoint = Pontuação + bonuspoint;
        Console.WriteLine($"Pontuação final: {totalpoint}");
    }
}