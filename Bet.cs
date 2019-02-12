using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_simulator
{
    public class Bet
    {
        public int amount;      //The amount of cash that was bet
        public int dog;         //The number of the dog the bet is on
        public Guy bettor;      //the guy who places the bet

        /// <summary>
        /// Return a string that says who placed the bet, how much cas was bet,
        /// and which dog he bet on. 
        /// If the amount is 0 no bet was placed.
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {            
                return bettor.name + " bets " + amount + " on dog #" + dog;
                      
        }

        /// <summary>
        /// The parameter is the winner of the race.
        /// If the dog won, return amount bet.
        /// Otherwise, return the negative of the amount bet.
        /// </summary>
        /// <returns></returns>
        public int PayOut(int winner)
        {
            if (dog == winner)
            {
                return amount;
            }
            else
            {
                return -amount;
            }
        }        
    }
}
