using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_ladder_upload
{
    internal class Program
    {
        public const int USER_STATE = 0;
        public const int IS_NO_PLAY = 0;
        public const int IS_LADDER = 1;
        public const int IS_SNAKE = 2;
        static void Main(string[] args)
        {
            Console.Write("Welcome to snake and Ladder program\n");
            int counts = 0, dice_played = 0, i = 0;
            Random random = new Random();
            while (counts <= 100)
            {
                int dice = random.Next(1, 7);
                //If the dice reaches 100 the loop ends
                if (counts == 100) { break; }
                int options = random.Next(0, 3);
                switch (options)
                {
                    case IS_NO_PLAY:
                        counts += 0;
                        
                        Console.WriteLine("No play-remains same");
                        Console.WriteLine("position=" + counts);
                        break;
                    case IS_LADDER:
                        counts += dice;
                        dice_played += 1;

                       
                        Console.WriteLine("Dice points:" + dice);
                        Console.WriteLine("position=" + counts);
                        break;
                    case IS_SNAKE:
                        counts -= dice;
                        //here reset occurs
                        if (counts < 0)
                        {
                            Console.WriteLine("---Game Restarts---");
                            counts = 0;
                        }

                        Console.WriteLine("Snake bit me :( go " + dice + " point back");
                        Console.WriteLine("position=" + counts);
                        break;
                }
                
               
            }


        }
    }
}
