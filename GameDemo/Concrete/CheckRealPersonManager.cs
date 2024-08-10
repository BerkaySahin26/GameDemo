using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    internal class CheckRealPersonManager : ICheckRealPerson
    {
        public bool Check(Gamer gamer)
        {
            return true;
        }
    }
}
