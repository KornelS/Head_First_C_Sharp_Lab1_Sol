using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_simulator
{
    public partial class Form1 : Form
    {
        public Greyhound[] GreyhoundArray = new Greyhound[4];
        public Guy[] GuysArray = new Guy[3];


        Random myRandomizer = new Random();

        public Form1()
        {
            InitializeComponent();
           

            GreyhoundArray[0] = new Greyhound()
            {
                myPictureBox = dog1,
                startingPosition = dog1.Left,
                racetrackLength = raceTrackPictureBox.Width - dog1.Width,
                randomizer = myRandomizer
            };

            GreyhoundArray[1] = new Greyhound()
            {
                myPictureBox = dog2,
                startingPosition = dog2.Left,
                racetrackLength = raceTrackPictureBox.Width - dog2.Width,
                randomizer = myRandomizer
            };

            GreyhoundArray[2] = new Greyhound()
            {
                myPictureBox = dog3,
                startingPosition = dog3.Left,
                racetrackLength = raceTrackPictureBox.Width - dog3.Width,
                randomizer = myRandomizer
            };

            GreyhoundArray[3] = new Greyhound()
            {
                myPictureBox = dog4,
                startingPosition = dog4.Left,
                racetrackLength = raceTrackPictureBox.Width - dog4.Width,
                randomizer = myRandomizer
            };

            
            GuysArray[0] = new Guy()
            {
                name = "Joe",
                myBet = null,
                cash = 50,
                myTextBox = joeTextBox,
                myRadioButton = joeRadioButton
            };

            GuysArray[1] = new Guy()
            {
                name = "Bob",
                myBet = null,
                cash = 75,
                myTextBox = bobTextBox,
                myRadioButton = bobRadioButton
            };

            GuysArray[2] = new Guy()
            {
                name = "Al",
                myBet = null,
                cash = 45,
                myTextBox = alTextBox,
                myRadioButton = alRadioButton
            };

            minimumBetLabel.Text = "Minimum bet: " + amountBettedNumerikUpDown.Minimum + " bucks";

            for (int i = 0; i < 3; i++)
            {
                GuysArray[i].UpdateTextBox();
            }

        }

        

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {            
            bettorNamelabel.Text = GuysArray[0].name;            
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bettorNamelabel.Text = GuysArray[1].name;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bettorNamelabel.Text = GuysArray[2].name;
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            int bet = (int)amountBettedNumerikUpDown.Value;
            int dogNo = (int)dogNumberNumerikUpDown.Value;

            if (joeRadioButton.Checked)
            {
                if (GuysArray[0].PlaceBet(bet, dogNo))
                {
                    joeTextBox.Text = GuysArray[0].myBet.GetDescription();
                }
                else
                {
                    MessageBox.Show(GuysArray[0].name + " doesn't have enough money");
                }
                
            }

            if (bobRadioButton.Checked)
            {
                if (GuysArray[1].PlaceBet(bet, dogNo))
                {
                    bobTextBox.Text = GuysArray[1].myBet.GetDescription();
                }
                else
                {
                    MessageBox.Show(GuysArray[1].name + " doesn't have enough money");
                }

            }

            if (alRadioButton.Checked)
            {
                if (GuysArray[2].PlaceBet(bet, dogNo))
                {
                    alTextBox.Text = GuysArray[2].myBet.GetDescription();
                }
                else
                {
                    MessageBox.Show(GuysArray[2].name + " doesn't have enough money");
                }

            }
        }

        private void startRaceButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            bettingParlorBox.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if(GreyhoundArray[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("The winner is dog #" + ++i + "!", "Winner announcement!");
                    for (int x = 0; x < 4; x++)
                    {
                        GreyhoundArray[x].TakeStartingPosition();
                    }
                    for (int y = 0; y < 3; y++)
                    {
                        GuysArray[y].Collect(i);
                        bettingParlorBox.Enabled = true;
                        GuysArray[y].UpdateTextBox();
                    }
                }
            }
        }

       
    }
}
