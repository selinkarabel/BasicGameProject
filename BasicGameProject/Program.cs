using System;

namespace BasicGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEGovUserValidationManager());
            gamerManager.SignIn(new Gamer { GamerId = 1, BirthYear = 1990, FirstName = "Selin", LastName="Karabel", IdentityNumber = "12345678910" });

            Gamer gamer1 = new Gamer();
            gamer1.GamerId = 1;
            gamer1.FirstName = "Sello";

            ICampaignService campaignService = new WinterSeasonCampaignManager();

            IOrderService order = new OrderManager(campaignService);
            order.Order(gamer1,campaignService);
           
        }
    }
}
