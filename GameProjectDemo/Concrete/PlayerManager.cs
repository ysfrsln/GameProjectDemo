using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    internal class PlayerManager : IPlayerService
    {
        IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                Console.WriteLine(player.FirstName + " Adlı Oyuncu Eklendi");
            }
            else
            {
                Console.WriteLine("Gerçek bir kişi değil");
            }

        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " Adlı Oyunce Silindi");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " Adlı Oyuncu Güncellendi");
        }
    }
}
