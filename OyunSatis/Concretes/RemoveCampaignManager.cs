using System;
using System.Collections.Generic;
using System.Text;
using OyunSatis.Abstract;

namespace OyunSatis.Concretes
{
    class RemoveCampaignManager:ICampaignService
    {
        public void RunCampaign()
        {
            Console.WriteLine("Campaign Removed to Succesfully");
        }
    }
}
