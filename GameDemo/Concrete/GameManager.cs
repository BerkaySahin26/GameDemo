using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Sell(Gamer gamer, Game game)
        {
           
            Console.WriteLine("oyun satıldı: " + gamer.Name + " " + game.Name);
            
        }
    }
}
