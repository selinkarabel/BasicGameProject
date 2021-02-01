using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameProject
{
    class NewEGovUserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
