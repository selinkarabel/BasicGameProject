using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameProject
{
    interface IGameService
    {
        void AddGame(Game game);
        void UpdateGame(Game game);
        void DeleteGame(Game game);

    }
}
