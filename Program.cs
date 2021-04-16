using System;
using System.Collections.Generic;
using System.Linq;


namespace PracticeLinq
{
    class Program
    {

        private static string[] videoGames = { "Halo", "Call of Duty", "Battlefield", "Witcher", "Medal of Honor" };

        static void Main(string[] args)
        {

            var num = videoGames;

            var orderList = num.OrderBy(list => list.Length);

            foreach (var item in orderList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
