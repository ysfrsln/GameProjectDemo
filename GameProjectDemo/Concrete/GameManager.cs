using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    internal class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " Adlı Oyun Eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " Adlı Oyun Silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "Oyun Güncellendi");
        }
    }
}
