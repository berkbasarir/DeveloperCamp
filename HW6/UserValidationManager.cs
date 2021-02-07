using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class UserValidationManager : IUserValidationService
    {

        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1988 && gamer.FirstName == "TOLGA" && gamer.LastName == "KÜÇÜK" && gamer.IdentityNumber == 123654)
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
