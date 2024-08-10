using Check;
using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Adapters
{
    public class MenrisServiceAdapter : ICheckRealPerson
    {
        public bool Check(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.Tckn), gamer.Name.ToUpper(), gamer.Surname.ToUpper(),
               gamer.BirthOfYear);
            return result.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
