using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Better21LoganC
{
    public class User : Player
    {
        // Private variables
        private Button hitButton;
        private Button stayButton;

        // Constructor takes a reference to the deck, the master form, and it's name
        // Calls the Player constructor
        public User(ref Deck d, frmBetter21 m, string inputName) : base (ref d, ref m)
        {
            // Sets the name
            name = inputName;

            // Set the UI positions
            UIx = 700;
            UIy = 400;
            handPosition = 550;

            // Create the UI elements
            CreateUI();
        }

        /* OVERRIDE FUNCTIONS */

        // Creates UI elements
        protected override void CreateUI()
        {
            // Call to the base class's create UI function
            base.CreateUI();

            // Creates a new Button for the user to hit
            hitButton = new Button();
            hitButton.Text = "Hit";
            hitButton.Location = new Point(UIx - 13, UIy + 83);
            hitButton.Click += new EventHandler(HitEvent);
            hitButton.BackColor = Control.DefaultBackColor;
            master.Controls.Add(hitButton);

            // Creates a new button for the user to stay
            stayButton = new Button();
            stayButton.Text = "Stay";
            stayButton.Location = new Point(UIx + 85, UIy + 83);
            stayButton.Click += new EventHandler(StayEvent);
            stayButton.BackColor = Control.DefaultBackColor;
            master.Controls.Add(stayButton);

            // Creates a new label to show the sum
            lblSum = new Label();
            lblSum.AutoSize = true;
            lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSum.ForeColor = System.Drawing.Color.White;
            lblSum.Location = new System.Drawing.Point(UIx + 150, UIy + 45);
            lblSum.Name = "lblSum";
            lblSum.Size = new System.Drawing.Size(86, 25);
            lblSum.TabIndex = 6;
            lblSum.Text = "Sum: 15";
            master.Controls.Add(lblSum);

            // Positions the Money label in the correct location
            lblMoney.Location = new System.Drawing.Point(UIx - 150, UIy + 45);

            // Disables buttons
            stayButton.Enabled = false;
            hitButton.Enabled = false;
        }

        // Prepares the player for a new round
        public override void NewRound(int buyin)
        {
            // Base class function call
            base.NewRound(buyin);

            // Hit twice
            Hit();
            Hit();

            // Disable controls
            EnableControls(false);
        }

        // Starts turn
        public override void StartTurn()
        {
            // Calls the base class function for start turn
            base.StartTurn();

            // Enable the buttons
            stayButton.Enabled = true;
            hitButton.Enabled = true;
        }
        
        // Signifies the end of the turn
        protected override void EndTurn()
        {
            // Disable the buttons
            stayButton.Enabled = false;
            hitButton.Enabled = false;

            // Call the base class function for end turn
            base.EndTurn();
        }

        // Handles the hit button press
        private void HitEvent(object sender, EventArgs e)
        {
            // Hit
            Hit();

            // If the user has busted or blackjacked, end the turn
            if (sum >= 21)
            {
                EndTurn();
            }  
        }

        // Handles the stay button press
        private void StayEvent(object sender, EventArgs e)
        {
            // End the turn
            EndTurn();
        }
    }
}
