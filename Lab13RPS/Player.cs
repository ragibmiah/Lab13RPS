using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPS
{
    abstract class Player
    {
        private string playerName;

        public string PlayerName { get => playerName; set => playerName = value; }

        public Player()
        {
            
        }

        public abstract Roshambo GenerateRoshambo();

        //public override string ToString()
        //{
        //    return $"{PlayerName}";
        //}



    }    
}
