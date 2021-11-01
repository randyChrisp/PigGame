using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PigGame.Models
{
    public class Player
    {
        public string Name { get; set; }

        public int Points { get; set; }

        Random rand;

        public Player()
        {
            Points = 0;

            rand = new Random();
        }

        public Roll Roll(int lastPoint)
        {
            Roll roll = new Roll();
            roll.Die = rand.Next(6) + 1;

            if(roll.Die == 1)
            {
                roll.Total = 0;
                roll.Continue = false;

                return roll;
            }

            roll.Total = lastPoint + roll.Die;
            roll.Continue = true;
            return roll;
        }

        public void Hold(Roll roll)
        {
            Points = Points + roll.Total;
        }
    }
}
