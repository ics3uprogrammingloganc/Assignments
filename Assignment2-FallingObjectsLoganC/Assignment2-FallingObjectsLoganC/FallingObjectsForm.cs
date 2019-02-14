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
            int yCurrentPos = 52;
            while (yCurrentPos < yFinalPos)
            {
                this.Refresh();
                Thread.Sleep(30);
                
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
            // Error was thrown, notifying the user that their input was invalid
            catch (Exception)
            {
                lblAnswer.Text = "Your entry is invalid. Try again.";
            }  
        }
    }
}
