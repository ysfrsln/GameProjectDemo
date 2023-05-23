using GameProjectDemo.Adapter;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Id = 1;
            player.NationalityId = "10073920204";
            player.FirstName = "Yusuf";
            player.LastName = "Eraslan";
            player.DateOfBirth = new DateTime(1989, 02, 23);
            player.UserName = "username";


            Offer offer = new Offer();
            offer.Id = 1;
            offer.OfferName = "Yaz Sezonu";


            Game game = new Game();
            game.Id = 1;
            game.GameName = "Counter Strike";




            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            playerManager.Add(player);

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            OfferManager offerManager = new OfferManager();
            offerManager.Add(offer);





            Console.ReadLine();


        }
    }
}
