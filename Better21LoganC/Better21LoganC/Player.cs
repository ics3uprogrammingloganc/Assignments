// Better21 game by Logan Cantin
// Player base class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Better21LoganC
{
    public abstract class Player
    {
        /* VARIABLES */

        // Card related stuff
        protected List<Card> hand = new List<Card>();
        protected Deck deck;

        //Variables
        protected int money;
        protected int sum;
        public string name;
        protected const int spacing = 85;
        protected int handPosition;

        // Graphics stuff
        protected int UIx;
        protected int UIy;
        protected Label lblName;
        protected Label lblMoney;
        protected Label lblSum;

        protected GroupBox groupBox;
        protected List<PictureBox> picBoxes = new List<PictureBox>();
        protected frmBetter21 master;

        /* CONSTRUCTOR */
        // Takes reference to deck and form.
        public Player(ref Deck d, ref frmBetter21 m)
        {
            // Sets the deck and master to the supplied values
            deck = d;
            master = m;

            // Sets the initial money
            money = 500;
        }

        // Starts turn
        virtual public void StartTurn()
        {
            EnableControls(true); // Enables all controls
            
        }

        // Ends turn
        virtual protected void EndTurn()
        {
            // Disables all controls
            EnableControls(false);

            // Asks master to go to the next person's turn
            master.NextTurn();
        }

        // Returns sum
        public int Sum
        {
            get
            {
                // Show sum label
                lblSum.Show();

                // End of game must be here, so flip all cards
                EnableControls(true);
                FlipCards();

                // If sum is over 21 (bust), show -1 so that this persons score is lower than everyone else who didnt bust
                if (sum > 21)
                {
                    return -1;
                }
                else
                {
                    // Else, show the sum
                    return sum;
                }
            }           
        }

        //Flips all cards
        protected virtual void FlipCards()
        {
            // Enumerators for pictureboxes and cards in the hand
            List<PictureBox>.Enumerator pbxEnum = picBoxes.GetEnumerator();
            List<Card>.Enumerator cardEnum = hand.GetEnumerator();

            // For each picture box and corresponding card
            while (pbxEnum.MoveNext() == true)
            {
                cardEnum.MoveNext();

                PictureBox tempPbx = pbxEnum.Current;

                // Change the current picturebox's image to the card image
                tempPbx.Image = cardEnum.Current.cardImage;
                
            }
        }

        // Prepares UI for a new round
        public virtual void NewRound(int buyin)
        {
            // Discards each card in the hand and clears it
            foreach (Card c in hand)
            {
                deck.Discard(c);
            }
            hand.Clear();

            // Deletes all pictureboxes and removes them from the form
            foreach (PictureBox pbx in picBoxes)
            {
                master.Controls.Remove(pbx);
                pbx.Dispose();
            }
            picBoxes.Clear();

            // Resets sum
            sum = 0;

            // Take away buy-in cost
            money -= buyin;

            // Update sum and money labels
            lblMoney.Text = name + "'s money: " + Convert.ToString(money);
            lblMoney.Refresh();
            lblSum.Text = string.Format("Sum: {0}", sum);
            lblSum.Refresh();

            // Disable controls
            EnableControls(false);
        }

        // Updates money after a win
        public virtual void Win(int winnings)
        {
            // Update money variable and Label
            money += winnings;
            lblMoney.Text = string.Format("{0}'s money: {1}", name, money);
        }

        // Enables or disables all UI elements
        protected virtual void EnableControls(bool operation)
        {
            // Disables the elements
            if (operation == false)
            {
                // Grey out all images and labels
                foreach (PictureBox p in picBoxes)
                {
                    p.Image = p.Image.GreyedOut();
                }
                lblName.ForeColor = Color.DarkGray;
                lblSum.ForeColor = Color.DarkGray;
                lblMoney.ForeColor = Color.DarkGray;
            }
            else // Enables the elements
            {
                // Enumerators for the pictureboxes and cards
                List<PictureBox>.Enumerator pbxEnum = picBoxes.GetEnumerator();
                List<Card>.Enumerator cardEnum = hand.GetEnumerator();

                // Iterate through the pictureboxes and their respective cards
                while (pbxEnum.MoveNext() == true)
                {
                    cardEnum.MoveNext();

                    PictureBox tempPbx = pbxEnum.Current;

                    // If the name is dealer, keep the cards face down
                    if (name == "Dealer")
                    {
                        tempPbx.Image = Card.backImage;
                    }
                    // If the Cards are greyed out, show their non-greyedout backs 
                    else if (tempPbx.Image == Card.backImage.GreyedOut())
                    {
                        tempPbx.Image = Card.backImage;
                    }
                    else if (tempPbx.Image == Card.backImage)
                    {
                        tempPbx.Image = Card.backImage;
                    }
                    // Otherwise, change current card image to the picturebox image
                    else
                    {
                        tempPbx.Image = cardEnum.Current.cardImage;
                    }        
                }
                // Make labels white
                lblName.ForeColor = Color.White;
                lblSum.ForeColor = Color.White;
                lblMoney.ForeColor = Color.White;
            }

            // Refresh form
            master.Refresh();
        }


        // Updates display to accomodate the new cards
        protected virtual void UpdateDisplay(bool faceDown = false)
        {
            // Figuring out how many cards there are
            int numCards = hand.Count();

            // Setting up new picture box
            Card newCard = hand.Last();
            PictureBox newPicBox = new PictureBox();
            newPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            newPicBox.ClientSize = Card.cardSize;
            newPicBox.Image = (faceDown) ? Card.backImage : newCard.cardImage; // back image if facedown, otherwise face image

            // Add picture box to the list of picboxes and master form's control list
            picBoxes.Add(newPicBox);
            newPicBox.BringToFront();
            master.Controls.Add(newPicBox);

            // setting UI variables for placement
            int center = master.Width / 2;
            int startPosition = center - (spacing * numCards / 2);

            // Setting location of each picturebox
            foreach (PictureBox pbx in picBoxes)
            {
                pbx.Location = new Point(startPosition, handPosition);

                startPosition += spacing;
            }

            // Updating sum labels
            lblSum.Text = "Sum: " + Convert.ToString(sum);

            // Refreshing form
            master.Refresh();
        }

        // Creating UI elements on the form
        protected virtual void CreateUI()
        {
            // Creating lblName
            lblName = new Label();
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblName.ForeColor = System.Drawing.Color.White;
            lblName.Location = new System.Drawing.Point(UIx, UIy);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(144, 46);
            lblName.TabIndex = 4;
            lblName.Text = name;
            master.Controls.Add(lblName);
            
            // Creating lblMoney
            lblMoney = new Label();
            lblMoney.AutoSize = true;
            lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMoney.ForeColor = System.Drawing.Color.White;
            lblMoney.Location = new System.Drawing.Point(UIx - 150, UIy + 45);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new System.Drawing.Size(127, 25);
            lblMoney.TabIndex = 5;
            lblMoney.Text = "Money: 500$";
            master.Controls.Add(lblMoney);

            // 
            // lblSum
            // 
            lblSum = new Label();
            lblSum.AutoSize = true;
            lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSum.ForeColor = System.Drawing.Color.White;
            lblSum.Location = new System.Drawing.Point(UIx + 150, UIy + 45);
            lblSum.Name = "lblSum";
            lblSum.Size = new System.Drawing.Size(86, 25);
            lblSum.TabIndex = 6;
            lblSum.Text = "Sum: 15";
            lblSum.Hide();
            master.Controls.Add(lblSum);

            
        }

        // The hit function
        protected virtual void Hit(bool faceDown = false)
        {
            // Get a new card from the deck
            Card newCard = deck.DealCard();

            // Add its value to the sum
            sum += newCard.numericalValue;

            // Add the new card to the hand
            hand.Add(newCard);

            // Update the display
            UpdateDisplay(faceDown);
        }

    }
}
