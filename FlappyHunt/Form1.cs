using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyHunt
{
    public partial class Form1 : Form
    {
        //Need to keep track of some info for the game
        int pipeSpeed = 5; //How fast the pipe will move
        int gravity = 10; //Speed of gravity
        int score = 0; //Keep track of the score/Distance traveled

        public Form1()
        {
            InitializeComponent();
        }
        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            //This will basically control the movement of pushing the space bar
            if (e.KeyCode == Keys.Space)
            {
                //It will appear like the hunter is going up
                gravity = -15;
            }

        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                //Once the space bar is released the gravity is set again so hunter will fall
                gravity = 5;
            }

        }

        private void endHunt()
        {
            //The hunt will end once this function runs
            huntTimer.Stop(); //Stop the timer
            lblScore.Text = "Your Hunt is over!!!"; //Displays the endgame message, += appends instead of overriding 
        }
        private void huntTimerEvent(object sender, EventArgs e)
        {
            picHunter.Top += gravity; //Adds the speed to the gravity so the hunter will fall
            picHive.Left -= pipeSpeed; //Moves the hive towards the left
            picDog.Left -= pipeSpeed; //Moves the dogs towards the left
            lblScore.Text = "Score: " + score; //Updates the score label

            //Check if the hive leaves the screen
            if (picHive.Left < -150)
            {
                //If the hive left the screen then the position is reset and score increased
                picHive.Left = 800;
                score++;
            }
            //Check if the dog leaves the screen
            if (picDog.Left < -180)
            {
                //If the dog left the screen then the position is reset and score increased
                picDog.Left = 950;
                
            }

            //Need to check if the hunter hits the ground or one of the obstacles
            if (picHunter.Bounds.IntersectsWith(picDog.Bounds) || picHunter.Bounds.IntersectsWith(picHive.Bounds) ||
                picHunter.Bounds.IntersectsWith(picGround.Bounds) || picHunter.Top < -25)
            {
                //If any condition is met then the game will end
                endHunt();
            }

            //If the score increases over 5 then the speed increaes
            if(score < 5)
            {
                pipeSpeed = 15;
            }
        

        }
        private void picHive_Click(object sender, EventArgs e)
        {

        }

        private void picDog_Click(object sender, EventArgs e)
        {

        }
    }
}
