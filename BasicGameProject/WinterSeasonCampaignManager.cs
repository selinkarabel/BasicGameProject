using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameProject
{
    class WinterSeasonCampaignManager : ICampaignService
    {
        public void AddCampaign()
        {
            Console.WriteLine("New winter season campaign is added");
        }

        public void DeleteCampaign()
        {
            Console.WriteLine("Winter season campaign is deleted");
        }

        public void UpdateCampaign()
        {
            Console.WriteLine("Winter season campaign is updated");
        }
    }
}
