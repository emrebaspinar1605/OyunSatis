using System;
using System.Collections.Generic;
using System.Text;
using OyunSatis.Entities;

namespace OyunSatis.Abstract
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);

    }
}
