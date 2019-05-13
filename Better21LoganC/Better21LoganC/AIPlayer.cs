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
        private int difficulty;
        private Random rndGen;
        int[] difficultyLevels = { 50, 70, 90, 99 };

        public AIPlayer(ref Deck d, frmBetter21 m, int dif, int num, string inputName) : base(ref d, ref m)
        {
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

            difficulty = difficultyLevels[dif];

            name = inputName;

            rndGen = new Random();

            CreateUI();
        }

        protected override void CreateUI()
        {
            base.CreateUI();

            lblSum.Location = new System.Drawing.Point(UIx, UIy + 90);
            lblMoney.Location = new System.Drawing.Point(UIx, UIy + 45);
        }

        public async override void StartTurn()
        {
            base.StartTurn();

            await Sleep.sleep(1000);

            while (deck.Peek() + sum < 22)
            {
                await Sleep.sleep(500);
                Hit(true);
            }

            int randint = rndGen.Next(1, 100);

            await Sleep.sleep(500);

            if (randint > difficulty)
            {
                Hit(true);
            }

            await Sleep.sleep(500);

            EndTurn();
        }

        public override void NewRound(int buyin)
        {
            base.NewRound(buyin);

            Hit(true);
            Hit(true);

            EnableControls(false);

            lblSum.Hide();
        }

        protected override void FlipCards()
        {
            base.FlipCards();

            foreach (PictureBox p in picBoxes)
            {
                p.Image = p.Image.RotateImage();
            }
        }

        protected override void UpdateDisplay(bool faceDown = false)
        {
            int numCards = hand.Count();

            Card newCard = hand.Last();
            PictureBox newPicBox = new PictureBox();
            newPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            newPicBox.ClientSize = new Size(Card.cardSize.Height, Card.cardSize.Width);
            newPicBox.Image = (faceDown) ? Card.backImage.RotateImage() : newCard.cardImage.RotateImage();

            picBoxes.Add(newPicBox);
            newPicBox.BringToFront();

            master.Controls.Add(newPicBox);

            int center = master.Height / 2;
            int startPosition = center - (spacing * numCards / 2);

            foreach (PictureBox pbx in picBoxes)
            {
                pbx.Location = new Point(handPosition, startPosition);

                startPosition += spacing;
            }

            lblSum.Text = "Sum: " + Convert.ToString(sum);

            master.Refresh();
        }

        protected override void EnableControls(bool operation)
        {

            if (operation == false)
            {
                foreach (PictureBox p in picBoxes)
                {
                    p.Image = p.Image.GreyedOut();
                }
                lblName.ForeColor = Color.DarkGray;
                lblSum.ForeColor = Color.DarkGray;
                lblMoney.ForeColor = Color.DarkGray;
            }
            else // Turning from greyed out back to regular
            {
                List<PictureBox>.Enumerator pbxEnum = picBoxes.GetEnumerator();
                List<Card>.Enumerator cardEnum = hand.GetEnumerator();

                while (pbxEnum.MoveNext() == true)
                {
                    cardEnum.MoveNext();

                    PictureBox tempPbx = pbxEnum.Current;

                    tempPbx.Image = Card.backImage.RotateImage();
                }
                
                lblName.ForeColor = Color.White;
                lblSum.ForeColor = Color.White;
                lblMoney.ForeColor = Color.White;
            }

            master.Refresh();
        }
    }
}
