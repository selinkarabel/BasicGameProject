using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameProject
{
    class GameManager : IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine("Game is added" + game.GameName);
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine("Game is added" + game.GameName);
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine("Game is added" + game.GameName);
        }
    }
}
