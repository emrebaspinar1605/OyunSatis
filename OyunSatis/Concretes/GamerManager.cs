using System;
using System.Collections.Generic;
using System.Text;
using OyunSatis.Entities;
using OyunSatis.Concretes;
using OyunSatis.Abstract;

namespace OyunSatis.Concretes
{
    class GamerManager
    {
        IUserValidationService _userValidationService;
        public  GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Gamer Added");
            }
            else
            {
                Console.WriteLine("Gamer Validation Failed");
            }
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted");
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated");
        }



    }
}
