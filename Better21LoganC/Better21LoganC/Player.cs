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
            // Sets the deck and master to the 
            deck = d;
            master = m;

            money = 500;
        }

        virtual public void StartTurn()
        {
            EnableControls(true);
            
        }

        virtual protected void EndTurn()
        {
            EnableControls(false);

            master.NextTurn();
        }

        public int Sum
        {
            get
            {
                // Show sum label
                lblSum.Show();

                EnableControls(true);
                FlipCards();

                if (sum > 21)
                {
                    return -1;
                }
                else
                {
                    return sum;
                }
            }           
        }

        protected virtual void FlipCards()
        {
            List<PictureBox>.Enumerator pbxEnum = picBoxes.GetEnumerator();
            List<Card>.Enumerator cardEnum = hand.GetEnumerator();

            while (pbxEnum.MoveNext() == true)
            {
                cardEnum.MoveNext();

                PictureBox tempPbx = pbxEnum.Current;

                tempPbx.Image = cardEnum.Current.cardImage;
                
            }
        }

        public virtual void NewRound(int buyin)
        {
            foreach (Card c in hand)
            {
                deck.Discard(c);
            }
            hand.Clear();
            foreach (PictureBox pbx in picBoxes)
            {
                master.Controls.Remove(pbx);
                pbx.Dispose();
            }
            picBoxes.Clear();

            sum = 0;

            money -= buyin;

            lblMoney.Text = name + "'s money: " + Convert.ToString(money);
            lblMoney.Refresh();

            lblSum.Text = string.Format("Sum: {0}", sum);
            lblSum.Refresh();

            EnableControls(false);
        }

        public virtual void Win(int winnings)
        {
            money += winnings;
            lblMoney.Text = string.Format("{0}'s money: {1}", name, money);
        }

        protected virtual void EnableControls(bool operation)
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
            else
            {
                List<PictureBox>.Enumerator pbxEnum = picBoxes.GetEnumerator();
                List<Card>.Enumerator cardEnum = hand.GetEnumerator();

                while (pbxEnum.MoveNext() == true)
                {
                    cardEnum.MoveNext();

                    PictureBox tempPbx = pbxEnum.Current;

                    if (name == "Dealer")
                    {
                        tempPbx.Image = Card.backImage;
                    }
                    else if (tempPbx.Image == Card.backImage.GreyedOut())
                    {
                        tempPbx.Image = Card.backImage;
                    }
                    else if (tempPbx.Image == Card.backImage)
                    {
                        tempPbx.Image = Card.backImage;
                    }
                    else
                    {
                        tempPbx.Image = cardEnum.Current.cardImage;
                    }        
                }
                lblName.ForeColor = Color.White;
                lblSum.ForeColor = Color.White;
                lblMoney.ForeColor = Color.White;
            }

            master.Refresh();
        }

        protected virtual void UpdateDisplay(bool faceDown = false)
        {
            int numCards = hand.Count();

            Card newCard = hand.Last();
            PictureBox newPicBox = new PictureBox();
            newPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            newPicBox.ClientSize = Card.cardSize;
            newPicBox.Image = (faceDown) ? Card.backImage : newCard.cardImage;

            picBoxes.Add(newPicBox);
            newPicBox.BringToFront();

            master.Controls.Add(newPicBox);

            int center = master.Width / 2;
            int startPosition = center - (spacing * numCards / 2);

            foreach (PictureBox pbx in picBoxes)
            {
                pbx.Location = new Point(startPosition, handPosition);

                startPosition += spacing;
            }

            lblSum.Text = "Sum: " + Convert.ToString(sum);

            master.Refresh();
        }

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

        protected virtual void Hit(bool faceDown = false)
        {
            Card newCard = deck.DealCard();

            sum += newCard.numericalValue;

            hand.Add(newCard);

            UpdateDisplay(faceDown);
        }

    }
}
