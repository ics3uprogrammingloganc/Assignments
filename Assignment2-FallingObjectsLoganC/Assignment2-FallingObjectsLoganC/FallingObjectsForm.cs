/*
 * Created by: Logan Cantin 
 * Created on: February 11th, 2019
 * Created for: ICS3U Programming
 * Assignment #2 - Falling Objects
 * This program calculates the height of a ball after however many seconds the user inputs.
 * Extra features:
 * - Error Checking
 * - Rounding
 * - Logical output
 * - Visual Representation
 * 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Assignment2_FallingObjectsLoganC
{
    public partial class frmFallingObjects : Form
    {

        public frmFallingObjects()
        {
            InitializeComponent();
        }

        // Rounding doubles to specified decimal places
        double roundDouble(double number, int decimalPlaces)
        {
            // Multiplying number by 10 ^ decimal places, rounding at that number, then dividing it back to the original number
            number *= Math.Pow(10, decimalPlaces);
            number = Math.Round(number);
            number *= Math.Pow(10, -decimalPlaces);

            return number;
        }

        // Animates falling ball
        void ballAnimate(int yFinalPos)
        {
            // Setting the ball to the original position
            int yCurrentPos = 52;

            // Loop that lowers the ball until it reaches it's final destination
            while (yCurrentPos < yFinalPos)
            {
                // get rid of the previous ball on the screen and wait 30 ms
                this.Refresh();
                Thread.Sleep(30);
                
                // Lower the ball's position by creating a new point 5 pixels lower than the previous height
                // and assigning it to the ball's location.
                yCurrentPos += 5;
                Point ballPos = new Point(500, yCurrentPos);
                pbxBall.Location = ballPos;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Initializing constants and variables
            const double GRAVITY = 9.81;
            double input, answer;
            
            // Begin Error Checking
            try
            {
                // Collecting user's input from the textbox
                input = Convert.ToDouble(tbxInput.Text);

                // Throwing an error if the input is negative ( can't have a negative time )
                if (input < 0)
                    throw new IndexOutOfRangeException();

                // Calculating the user's answer, and if it's negative setting it to zero
                answer = 100 - 0.5 * GRAVITY * Math.Pow(input, 2);
                if (answer < 0)
                    answer = 0;
                else
                    answer = roundDouble(answer, 2);

                // Setting the answer text
                lblAnswer.Text = "The ball is " + answer + " meters off the ground.";

                //Changing the position of the ball
                int newBallY =  50 + Convert.ToInt32(373 * (100 - answer) / 100);

                ballAnimate(newBallY);
                
            }
            // Negative input error handling, notifying the user their number must be positive
            catch (IndexOutOfRangeException)
            {
                lblAnswer.Text = "Your answer can't be negative. Try again.";
            }
            // Error was thrown, notifying the user that their input was invalid
            catch (Exception)
            {
                lblAnswer.Text = "Your entry is invalid. Try again.";
            }  
        }
    }
}
