using System;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
                gamerManager.Add(new Gamer { Id = 1, BirthYear = 1988, FirstName = "TOLGA", LastName = "KÜÇÜK", IdentityNumber = 123654 });
        }
    }
}
