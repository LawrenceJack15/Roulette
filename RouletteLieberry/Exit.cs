using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLieberry
{
    public class Exit
    {
        public void exit()
        {
            Bets bets = new Bets();
            Console.WriteLine("\nDo you want to play again? (y/n)");
            string n = Console.ReadLine();
            if (n.ToUpper() != "N")
            {
                Console.Clear();
                bets.bets();
            }
            else
            {
                Console.WriteLine("Thanks for stopping by!!!!!!!");
                Environment.Exit(0);
            }
        }
    }
}
