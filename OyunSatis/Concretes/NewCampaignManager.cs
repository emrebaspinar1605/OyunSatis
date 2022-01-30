using System;
using System.Collections.Generic;
using System.Text;
using OyunSatis.Entities;
using OyunSatis.Concretes;
using OyunSatis.Abstract;

namespace OyunSatis.Concretes
{
    class NewCampaignManager : ICampaignService
    {
        public void RunCampaign()
        {
            Console.WriteLine("New Campaign Succesfully");
        }

    
    }
}
