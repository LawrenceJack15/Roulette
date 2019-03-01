using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLieberry
{
    public class Bets
    {
        public void bets()
        {
            Exit exit = new Exit();
            Random rnd = new Random();
            Methods methods = new Methods();

            int Num = 0;
            int Nums = 0;
            int[] RedNums = { -1, 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] BlackNums = { 0, 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

            var A = rnd.Next(1, 51);
            if (A > 25)
            {
                Num = rnd.Next(RedNums.Length);
                Nums = Convert.ToInt32(RedNums[Num]);
                if (Nums == -1)
                {
                    Console.WriteLine("You landed on 00 no other bets were won\n");
                    exit.exit();
                }
            }
            else
            {
                Num = rnd.Next(BlackNums.Length);
                Nums = Convert.ToInt32(BlackNums[Num]);
                if (Nums == 0)
                {
                    Console.WriteLine("You landed on 0 no other bets were won\n");
                    exit.exit();
                }
            }

            Console.WriteLine("You landed on: {0}\n", Nums);
            Console.WriteLine("You won the following bets:");

            string EvenOdd = methods.EvenOdd(Nums);
            Console.WriteLine($"{EvenOdd} Number");

            string RedBlack = methods.RedBlack(Nums, RedNums);
            Console.WriteLine($"{RedBlack}");

            string LowsHighs = methods.LowsHighs(Nums);
            Console.WriteLine($"{LowsHighs} Number");

            string Dozens = methods.Dozens(Nums);
            Console.WriteLine($"{Dozens}");

            string Columns = methods.Columns(Nums);
            Console.WriteLine($"{Columns}");

            string Street = methods.Street(Nums);
            Console.WriteLine($"{Street}");

            string DoubleRows = methods.DoubleRows(Nums);
            Console.WriteLine($"{DoubleRows}");

            string Split = methods.Split(Nums);
            Console.WriteLine($"Splits: {Split}");

            string Corner = methods.Corner(Nums);
            Console.WriteLine($"{Corner}");

            exit.exit();
        }
    }
}
