using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager : IPlayerService
    {
        public void Add(Player player)
        {
            Console.WriteLine("oyuncu eklendi");
        }

        public void Delete(Player player)
        {
            Console.WriteLine("oyuncu silindi.");
        }

        public void Update(Player player)
        {
            Console.WriteLine("oyuncu güncellendi.");
        }
    }
}
