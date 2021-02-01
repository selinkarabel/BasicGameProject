using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameProject
{
    class HolidaySeasonCampaignManager : ICampaignService
    {
        public void AddCampaign()
        {
            Console.WriteLine("New holiday season campaign is added");
        }

        public void DeleteCampaign()
        {
            Console.WriteLine("Holiday season campaign is deleted");
        }

        public void UpdateCampaign()
        {
            Console.WriteLine("Holiday season campaign is updated");
        }
    }
}
