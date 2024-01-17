namespace Dice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int playerRandNum;
            int enemyRandNum;
            int playerScore = 0;
            int enemyScore = 0;
            ConsoleKeyInfo key;

            Random random = new Random();
            while (true)
            {
                Console.WriteLine("Press Enter to roll the dice, 'Q' to exit");
                key = Console.ReadKey();

                if (key.Key != ConsoleKey.Q)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        playerRandNum = random.Next(1, 7);
                        enemyRandNum = random.Next(1, 7);

                        Thread.Sleep(300);
                        Console.WriteLine("\nYou rolled: {0}", playerRandNum);
                        Thread.Sleep(300);
                        Console.WriteLine("Enemy rolled: {0}", enemyRandNum);
                        if (playerRandNum > enemyRandNum)
                        {
                            playerScore++;
                            Console.WriteLine("player wins this round!");
                        }
                        else if (enemyRandNum > playerRandNum)
                        {
                            enemyScore++;
                            Console.WriteLine("enemy wins this round!");
                        }
                        else
                        {
                            Console.WriteLine("Draw!");
                        }
                        Console.WriteLine("players score (player: {0}, enemy: {1})\n", playerScore, enemyScore);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                else
                {
                    break;
                }
            }
            if (playerScore > enemyScore)
            {
                Console.WriteLine("\n\nPlayer Wins!!");
            }
            else if (playerScore < enemyScore)
            {
                Console.WriteLine("\n\nenemy Wins!!");
            }
            else
            {
                Console.WriteLine("\n\nDraw!");
            }
        }
    }
}