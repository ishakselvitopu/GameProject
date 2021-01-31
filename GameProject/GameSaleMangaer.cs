using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSaleMangaer : IGameSaleService
    {
        public void SatisYap(Game game, Campaign campaign, Player player)
        {
            Console.WriteLine(player.FirstName+" "+"isimli oyuncuya"+" "+game.Name+" "+"oyununu"+" "+campaign.Name+" "+"kapsamında"+" "+campaign.Rate+" "+"oranında"+" "+"satılmuştır."+"\n"+"iyi oyunlar");
        }
    }
}
