using System;
using System.Collections.Generic;
using System.Text;
using OyunSatis.Entities;
using OyunSatis.Concretes;
using OyunSatis.Abstract;

namespace OyunSatis.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
        
    }
}
