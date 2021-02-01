using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameProject
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {   //Simulation of validation of gamer instead of mernis
            if (gamer.BirthYear == 1990 && gamer.FirstName == "Selin" && gamer.LastName == "Karabel" 
                && gamer.IdentityNumber == "12345678910")
            {
                return true;
            }

            else
            {
                return false;
            }
                    
        }
    }
}
