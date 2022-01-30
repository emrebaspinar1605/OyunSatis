using System;
using OyunSatis.Concretes;
using OyunSatis.Entities;
using OyunSatis.Abstract;

namespace OyunSatis
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer Emre = new Gamer()
            {
                Ad="Emre",
                SoyAd="Başpınar",
                DateOfBirth=new DateTime(2002,5,30),
                TcKimlik=15112490946
            };
            Gamer Enes = new Gamer()
            {
                Ad = "Enes",
                SoyAd = "Başpınar",
                DateOfBirth = new DateTime(1999, 3, 23),
                TcKimlik = 14425111514
            };
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(Emre);
            gamerManager.Add(Enes);
            
            OrderManager orderManager = new OrderManager();
         
            orderManager.Order(Enes,new NewCampaignManager());
            orderManager.Order(Emre, new UpdateCampaignManager());
            orderManager.Order(Enes, new RemoveCampaignManager());
        }
    }

}
