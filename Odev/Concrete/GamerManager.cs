using Odev.Abstract;
using Odev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev.Concrete
{
    public class GamerManager : IGamerService
    {
        public GamerManager()
        {

        }
        private IVerificationService verificationService;
        public GamerManager(IVerificationService verificationService)
        {
            this.verificationService = verificationService;
        }
        public void Add(Gamer gamer) 
        {
            if (verificationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName+gamer.LastName+"Adlı oyuncu eklendi");
            }
            else
            {
                Console.WriteLine("Bilgilerinizi tekrar kontrol ediniz");
            }
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + "Adlı oyuncu silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + "Adlı oyuncu güncellendi");
        }
    }
}
