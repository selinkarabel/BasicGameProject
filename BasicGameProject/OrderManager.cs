using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameProject
{
    class OrderManager : IOrderService
    {
        ICampaignService _campaignService;

        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Order(Gamer gamer,ICampaignService campaign)
        {
            _campaignService.AddCampaign();
            Console.WriteLine("Order is successfull by " + gamer.FirstName);
        }
    }
}
