using System;

namespace HighScore
{
    class Program
    {
        
        static int highScore = 300;
        static string highScorePlayer = "Ufuk";

        static void Main(string[] args)
        {
            
            CheckHighScore(250, "erkut");
            CheckHighScore(349, "gamze");
            CheckHighScore(400, "taylan");
            CheckHighScore(500, "mustafa");
            CheckHighScore(600, "mertcan");

        }
        public static void CheckHighScore(int score, string playerName)
        {
            if (score > highScore)
            {
                highScore = score;
                highScorePlayer = playerName;
                Console.WriteLine("New HighScore is " + score);
                Console.WriteLine("New Highscore holder is " + playerName);
            }
            else
            {
                Console.WriteLine("The old HighScore of " + highScore +" could not be broken and is still held by " + highScorePlayer );
            }

        }
    }
}