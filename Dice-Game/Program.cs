namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;
            int playerPoints = 0;
            int enemyPoints = 0;
            Random random = new Random();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("-------------------------------");

                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine($"you rolled a {playerRandomNum}");

                Console.WriteLine("....");
                System.Threading.Thread.Sleep(400);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine($"enemy AI rolled a {enemyRandomNum}");

                if(enemyRandomNum > playerRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round");
                }
                else if (enemyRandomNum < playerRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
            }

            Console.WriteLine();

            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("you win");
            }
            else if (playerPoints > enemyPoints)
            {
                Console.WriteLine("you Lose");
            }
            else
            {
                Console.WriteLine("It's Draw!");
            }

            Console.ReadKey();
        }
    }
}
