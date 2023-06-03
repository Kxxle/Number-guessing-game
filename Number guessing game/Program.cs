using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Choose your minimum number?");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose your maximum number?");
            int y = Convert.ToInt32(Console.ReadLine());
            rand.Next(x,y);

            Console.ReadKey();
        }
    }
}
