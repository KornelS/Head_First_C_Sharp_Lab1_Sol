using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_simulator
{
    public class Guy
    {
        public string name;     //The Guy's name
        public Bet myBet;       //An instance of bet that has his bet
        public int cash;        //How much cash he has

        public RadioButton myRadioButton;
        public TextBox myTextBox;

        /// <summary>
        /// Set my textbox to my bet's description,
        /// and the on my radio button to show my cash
        /// </summary>
        public void UpdateTextBox()
        {
            myRadioButton.Text = name + " has " + cash + " bucks";
            if (myBet == null)
            {
                myTextBox.Text = name + " hasn't placed a bet";
            }         
        }

        /// <summary>
        /// Reset my bet to null
        /// </summary>
        public void ClearBet()
        {
            myBet = null;

        }

        /// <summary>
        /// Place a new bet and store it in my bet field.
        /// Return true if the guy had enough money to bet
        /// </summary>        
        public bool PlaceBet(int betAmmount, int dogToWin)
        {
            if (cash >= betAmmount)
            {
                myBet = new Bet()
                {
                    amount = betAmmount,
                    dog = dogToWin,
                    bettor = this
                };
                return true;
            }           
            return false;            
        }

        /// <summary>
        /// Ask my bet to pay out, clear my bet, and update my labels
        /// </summary>
        public void Collect(int winner)
        {
            if (myBet != null)
            {
                cash += myBet.PayOut(winner);             
            }
            ClearBet();
        }
    }
}
