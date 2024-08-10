using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface ICampaignService
    {
        void Add(Game game, Campaign campaign);
        void Update(Game game, Campaign campaign);
        void Delete(Game game, Campaign campaign);
    }
}
