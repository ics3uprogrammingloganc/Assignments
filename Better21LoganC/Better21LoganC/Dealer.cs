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
    public class Dealer : Player
    {
        private Label sumLabel;
        private int sum;
        private List<Card> hand = new List<Card>();
        Deck deck;
        frmBetter21 master;
        List<PictureBox> picBoxes= new List<PictureBox>();


        const int spacing = 85;


        public Dealer(ref Deck d, frmBetter21 m)
        {
            deck = d;
            master = m;

            CreateDealerUI();
        }

        private void UpdateDisplay()
        {
            int numCards = hand.Count();

            Card newCard = hand.Last();
            PictureBox newPicBox = new PictureBox();
            newPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            newPicBox.ClientSize = Card.cardSize;
            newPicBox.Image = newCard.cardImage;

            sumLabel.Text = "Sum: " + Convert.ToString(sum);

            picBoxes.Add(newPicBox);

            master.Controls.Add(newPicBox);

            int center = master.Width / 2;
            int startPosition = center - (spacing * numCards / 2);
            
            foreach (PictureBox pbx in picBoxes)
            {
                pbx.Location = new Point(startPosition, 20);

                startPosition += spacing;
            }

            master.Refresh();
        }

        private void Hit()
        {
            Card newCard = deck.DealCard();

            Console.WriteLine("Hit: " + Convert.ToString(newCard.numericalValue));

            sum += newCard.numericalValue;

            hand.Add(newCard);

            UpdateDisplay();
        }

        public override void StartTurn()
        {
            Hit();
            Hit();

            while (sum < 16)
            {
                Thread.Sleep(1000);
                Hit();
            }
        }

        private void CreateDealerUI()
        {
            sumLabel = new Label();
            sumLabel.Text = "Sum: 0";
            sumLabel.Location = new Point(master.Width / 2, master.Height / 4);
            master.Controls.Add(sumLabel);
        }
    }
}
