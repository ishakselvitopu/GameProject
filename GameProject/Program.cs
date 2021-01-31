using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //oyuncu ekleme
            PlayerManager playerManager = new PlayerManager();
            Player player = new Player();
            player.Id = 1;
            player.FirstName = "ishak";
            player.LastName = "selvitopu";
            player.TcNo = 11111;
            player.BirhtDay = 1994;
            playerManager.Add(player);
            //kampanya tanımlama
            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign();
            campaign.Id = 101;
            campaign.Name = "Kış indirimi";
            campaign.Rate = "%20";
            campaignManager.Add(campaign);
            //oyun tanımlama
            GameManager gameManager = new GameManager();
            Game game = new Game();
            game.Id = 100;
            game.Name = "Fm2021";
            game.Price = 199;
            gameManager.Add(game);
            Console.ReadLine();
            //oyun satışı
            GameSaleMangaer gameSaleMangaer = new GameSaleMangaer();
            gameSaleMangaer.SatisYap(game,campaign,player);
        }
    }
}
