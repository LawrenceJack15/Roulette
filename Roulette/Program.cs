using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouletteLieberry;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Bets bets = new Bets();
            bets.bets();

            Exit exit = new Exit();
            exit.exit();
        }
    }
}
