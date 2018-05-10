using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPS
{
    class Player2 : Player
    {
        private string playerName;

        public Player2()
        {
            PlayerName = "Ghost";
        }

        public override Roshambo GenerateRoshambo()
        {
           Random rnd = new Random();
           int selection = rnd.Next(0, 3);
           return (Roshambo)selection;  
           
        }


        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}

