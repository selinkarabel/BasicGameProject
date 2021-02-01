using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameProject
{
    class GamerManager : IGamerService
    {
        IUserValidation _userValidation;

        public GamerManager(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted");
        }

        public void SignIn(Gamer gamer)
        {
            // dont use the method of KPS to validate gamer here
            // use microservice
            if (_userValidation.Validate(gamer))
            {
                Console.WriteLine("Gamer added");
            }
            else
            {
                Console.WriteLine("Gamer can not be added because the system could not validate this user");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated");
        }
    }
}
