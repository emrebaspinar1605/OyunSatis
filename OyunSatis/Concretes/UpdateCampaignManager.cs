using System;
using System.Collections.Generic;
using System.Text;
using OyunSatis.Concretes;
using OyunSatis.Entities;
using OyunSatis.Abstract;

namespace OyunSatis.Concretes
{
    class UpdateCampaignManager:ICampaignService
    {

        public void RunCampaign()
        {
            Console.WriteLine("Campaign Update to Succesfully");
        }
    }
}
