using System;
using System.Collections.Generic;
using System.Text;
using OyunSatis.Abstract;
using OyunSatis.Concretes;
using OyunSatis.Entities;
namespace OyunSatis.Concretes
{
    class OrderManager 
    {
     public void Order(Gamer gamer,ICampaignService campaignService)
        {
            campaignService.RunCampaign();
            Console.WriteLine("To the player named as "+gamer.Ad+" "+gamer.SoyAd+" "+ "Above campaign action defined succesfully.");
        }

        
    }
}
