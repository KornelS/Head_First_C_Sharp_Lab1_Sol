using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_simulator
{
    public class Greyhound
    {
        public int startingPosition;            //Where the PictureBox starts
        public int racetrackLength;             //How long the racetrack is
        public PictureBox myPictureBox = null;  //My PictureBox object
        public int location = 0;                //My location on the racetrack
        public Random randomizer;               //An instance of random

        /// <summary>
        /// Move Forward either 1,2,3 or 4 spaces at random,
        /// updare the position of myPictureBox
        /// return true if won the race
        /// </summary>
        /// <returns></returns>
        public bool Run()
        {
            location += randomizer.Next(1, 5);
            myPictureBox.Left = startingPosition + location;
            
            if (myPictureBox.Left >= racetrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Reset location to 0 and myPictureBox to starting position
        /// </summary>
        public void TakeStartingPosition()
        {
            myPictureBox.Left = 13;
            location = 0;
        }


    }
}
