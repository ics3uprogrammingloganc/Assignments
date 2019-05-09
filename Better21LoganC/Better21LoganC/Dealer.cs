using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Better21LoganC
{
    public class Dealer
    {
        private int sum;
        private List<Card> hand = new List<Card>();
        Deck deck;
        frmBetter21 master;
        List<PictureBox> picBoxes;


        public Dealer(ref Deck d)
        {
            deck = d;
        }

        private void UpdateDisplay()
        {
            int numCards = hand.Count();

            Card newCard = hand.Last();
            PictureBox newPicBox = new PictureBox();
            newPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            newPicBox.ClientSize = Card.cardSize;
            newPicBox.Image = newCard.cardImage;

            picBoxes.Add(newPicBox);

            

            foreach (PictureBox pbx in picBoxes)
            {

            }


        }

        private void Hit()
        {
            Card newCard = deck.DealCard();

            hand.Add(newCard);

            UpdateDisplay();
        }

        public void StartTurn()
        {
            
        }
    }
}
