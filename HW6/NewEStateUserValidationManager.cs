using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
