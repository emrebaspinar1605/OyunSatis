using System;
using System.Collections.Generic;
using System.Text;
using OyunSatis.Entities;
using OyunSatis.Concretes;
using OyunSatis.Abstract;

namespace OyunSatis.Concretes
{
    class UserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Ad=="Emre"&&gamer.SoyAd=="Başpınar"&&gamer.DateOfBirth==new DateTime(2002,5,30)&&gamer.TcKimlik==15112490946)
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
