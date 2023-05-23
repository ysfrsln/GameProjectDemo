using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    internal class OfferManager : IOfferService
    {
        public void Add(Offer offer)
        {
            Console.WriteLine(offer.OfferName + " İndirim Eklendi");
        }

        public void Delete(Offer offer)
        {
            Console.WriteLine(offer.OfferName + " İndirim Silindi");
        }


    }
}