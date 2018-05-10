using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPS
{
    class Player3: Player
    {
        private string playerName;

        public Player3()
        {
            PlayerName = Console.ReadLine();

        }

        public override Roshambo GenerateRoshambo()
        {
            Console.Write("Rock, paper, or scissors? (1,2, or 3) ");
            string input = Console.ReadLine();

            int result;
            int.TryParse(input, out result);

            if (result == 1)
            {
                return Roshambo.Rock;
            }
            else if (result == 2)
            {
                return Roshambo.Paper;
            }
            else
            {
                return Roshambo.Scissors;
            }
          
        }
    }
}
