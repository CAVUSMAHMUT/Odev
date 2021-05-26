using Odev.Abstract;
using Odev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev.Concrete
{
    public class IVerifictionManager : IVerificationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.NationaltyId.Length==11)
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
