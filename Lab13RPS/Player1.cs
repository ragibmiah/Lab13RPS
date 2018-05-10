using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPS
{
    class Player1 : Player
    {
        private string playerName;

        public Player1() 
        {
           PlayerName = "Price";
        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
        //public override string ToString()
        //{
        //    return base.ToString();
        //}
        
    }
}
