using Odev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev.Abstract
{
    public interface IVerificationService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
