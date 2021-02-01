using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameProject
{
    interface IOrderService
    {
        void Order(Gamer gamer);
        void Order(Gamer gamer, ICampaignService campaign);
        
    }
}
