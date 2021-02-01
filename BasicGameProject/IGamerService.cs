using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameProject
{
    interface IGamerService
    {
        void SignIn(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
