using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_ladder_upload
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Welcome to snake and Ladder program\n");
            int counts = 0, dice_played = 0, i = 0;
            Random random = new Random();
            while (counts <= 100)
            {
                int dice = random.Next(1, 7);
                counts += dice;
                Console.Write("\n Player Position :" + counts);
                counts++;
            }


        }
    }
}
