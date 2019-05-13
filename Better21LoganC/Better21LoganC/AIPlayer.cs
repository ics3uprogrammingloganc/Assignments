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
    public class AIPlayer : Player
    {
        // Private Variables
        private int difficulty;
        private Random rndGen;
        private int[] difficultyLevels = { 50, 70, 90, 99 };

        // Constructor takes reference to deck, master, difficulty, which position to be in, and the name
        public AIPlayer(ref Deck d, frmBetter21 m, int dif, int num, string inputName) : base(ref d, ref m)
        {
            // Setting the UI variables based on the position
            if (num == 2)
            {
                UIx = 1100;
                UIy = 300;
                handPosition = 1350;
            }
            if (num == 1)
            {
                UIx = 200;
                UIy = 300;
                handPosition = 50;
            }

            // Set the difficulty
            difficulty = difficultyLevels[dif];

            // Setting the name
            name = inputName;

            // Create a new random generator
            rndGen = new Random();

            // Create the UI
            CreateUI();
        }

        /* OVERRIDE FUNCTIONS */
        
        // Creates the UI elements
        protected override void CreateUI()
        {
            // Calls the base class function
            base.CreateUI();

            // Repositions the sum and money labels
            lblSum.Location = new System.Drawing.Point(UIx, UIy + 90);
            lblMoney.Location = new System.Drawing.Point(UIx, UIy + 45);
        }

        // Starts turn
        public async override void StartTurn()
        {
            // Calls the base function
            base.StartTurn();

            // Wait 1 second without disturbing UI functionality such as clicking, etc
            await Sleep.sleep(1000);

            // Keep hitting until the next card will cause a bust
            while (deck.Peek() + sum < 22)
            {
                await Sleep.sleep(500); // Wait half a second
                Hit(true); // Hit facedown
            }

            // Generate a new random number
            int randint = rndGen.Next(1, 100);

            // Wait half a second
            await Sleep.sleep(500);

            // Decide if the player will bust or not
            if (randint > difficulty)
            {
                Hit(true); // Hit facedown
            }

            // Wait half a second
            await Sleep.sleep(500);

            // End turn
            EndTurn();
        }

        // Resets UI for a new round
        public override void NewRound(int buyin)
        {
            // Calling the base function
            base.NewRound(buyin);

            // Hit twice, facedown
            Hit(true);
            Hit(true);

            // Disable controls
            EnableControls(false);

            // Hide the sum
            lblSum.Hide();
        }

        // Flips all cards
        protected override void FlipCards()
        {
            // Calls the base function
            base.FlipCards();

            // Rotate each picture 90 degrees
            foreach (PictureBox p in picBoxes)
            {
                p.Image = p.Image.RotateImage();
            }
        }

        // Updates display to show new card.
        // This function had to be rewritten because it works fundamentally differently than the ones for dealer and user
        protected override void UpdateDisplay(bool faceDown = false)
        {
            // Sets number of cards
            int numCards = hand.Count();

            // Accesses last card of the hand (the one that was just added), and creates a picture box for it
            Card newCard = hand.Last();
            PictureBox newPicBox = new PictureBox();
            newPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            newPicBox.ClientSize = new Size(Card.cardSize.Height, Card.cardSize.Width);
            newPicBox.Image = (faceDown) ? Card.backImage.RotateImage() : newCard.cardImage.RotateImage(); // Image is the back image if card is meant to be facedown

            // Add new picture box to picBox list
            picBoxes.Add(newPicBox);
            newPicBox.BringToFront();

            // Add new picture box to the list of controls
            master.Controls.Add(newPicBox);

            // Define the center position and the start position
            int center = master.Height / 2;
            int startPosition = center - (spacing * numCards / 2);

            // Place the pictureboxes in their new positions
            foreach (PictureBox pbx in picBoxes)
            {
                pbx.Location = new Point(handPosition, startPosition);

                startPosition += spacing;
            }

            // Update the sum label
            lblSum.Text = "Sum: " + Convert.ToString(sum);

            // Refresh the form
            master.Refresh();
        }

        // Enables or disables the controls
        protected override void EnableControls(bool operation)
        {
            if (operation == false) // Disables (greys out images)
            {
                foreach (PictureBox p in picBoxes)
                {
                    p.Image = p.Image.GreyedOut();
                }

                // Sets grey color on the labels
                lblName.ForeColor = Color.DarkGray;
                lblSum.ForeColor = Color.DarkGray;
                lblMoney.ForeColor = Color.DarkGray;
            }
            else // Enables (greyed out to regular)
            {
                // Defines some enumerators to iterate through the lists
                List<PictureBox>.Enumerator pbxEnum = picBoxes.GetEnumerator();
                List<Card>.Enumerator cardEnum = hand.GetEnumerator();

                // While there are more cards left in the hand to enable
                while (pbxEnum.MoveNext() == true)
                {
                    // Move to the next card
                    cardEnum.MoveNext();

                    // Get the current picturebox
                    PictureBox tempPbx = pbxEnum.Current;

                    // Assign the current card image to the current picture box, rotating it as well
                    tempPbx.Image = Card.backImage.RotateImage();
                }
                
                // Sets white color on labels
                lblName.ForeColor = Color.White;
                lblSum.ForeColor = Color.White;
                lblMoney.ForeColor = Color.White;
            }

            // Refreshes the form
            master.Refresh();
        }
    }
}
