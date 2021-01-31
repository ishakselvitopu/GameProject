using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameSaleService
    {
        void SatisYap(Game game, Campaign campaign, Player player);
    }
}
