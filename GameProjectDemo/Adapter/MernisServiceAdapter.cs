using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using GameProjectDemo.MernisTcNoDogrulama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Adapter
{
    internal class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalityId),player.FirstName.ToUpper(),player.LastName.ToUpper(),player.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
