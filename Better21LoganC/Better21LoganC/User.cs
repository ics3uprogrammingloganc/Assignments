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
        const int y = 550;

        private Button hitButton;
        private Button stayButton;


        public User(ref Deck d, frmBetter21 m, string inputName) : base (ref d, ref m)
        {
            name = inputName;

            UIx = 700;
            UIy = 400;

            handPosition = 550;

            CreateUI();
        }

        protected override void CreateUI()
        {
            base.CreateUI();

            hitButton = new Button();
            hitButton.Text = "Hit";
            hitButton.Location = new Point(UIx - 13, UIy + 83);
            hitButton.Click += new EventHandler(HitEvent);
            hitButton.BackColor = Control.DefaultBackColor;
            master.Controls.Add(hitButton);

            stayButton = new Button();
            stayButton.Text = "Stay";
            stayButton.Location = new Point(UIx + 85, UIy + 83);
            stayButton.Click += new EventHandler(StayEvent);
            stayButton.BackColor = Control.DefaultBackColor;
            master.Controls.Add(stayButton);

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

            lblMoney.Location = new System.Drawing.Point(UIx - 150, UIy + 45);

            stayButton.Enabled = false;
            hitButton.Enabled = false;

            Console.WriteLine(lblSum.Location);
        }

        public override void NewRound(int buyin)
        {
            base.NewRound(buyin);

            Hit();
            Hit();

            EnableControls(false);
        }

        public override void StartTurn()
        {
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

            base.EndTurn();
        }

        // Handles the hit button press
        private void HitEvent(object sender, EventArgs e)
        {
            Hit();

            if (sum > 21)
            {
                Console.WriteLine("bust");
                EndTurn();
            }
            else if (sum == 21)
            {
                Console.WriteLine("blackjack");
                EndTurn();
            }
            
        }

        // Handles the stay button press
        private void StayEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Stay");
            EndTurn();
        }
    }
}
