using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Resources;
using System.IO;
using System.Windows.Forms;

namespace Better21LoganC
{
    public struct Card
    {
        public Image cardImage;
        public int numericalValue;
        public char suit;
        public Image backImage;

        public static Size cardSize = new Size(70, 100);

        public Card(Image img, int number, char suitChar)
        {
            cardImage = img;
            numericalValue = (number < 10) ? number : 10;
            suit = suitChar;
            backImage = new Bitmap(@"Cards\purple_back.png");
        }
    }

    public class Deck
    {
        private Queue cards = new Queue();
        private List<Card> discard = new List<Card>();
        private Random randGen = new Random();

        public Deck()
        {
            foreach (char suit in "SHDC")
            {
                for (int numberValue = 1; numberValue <= 13; numberValue++)
                {
                    Image cardImage = GetCardImage(suit, numberValue);

                    Card newCard = new Card(cardImage, numberValue, suit);

                    discard.Add(newCard);
                }
            }

            ShuffleCards();
        }

        Image GetCardImage(char suit, int number)
        {
            string path;
            Image img;

            if (number == 11)
            {
                path = @"Cards\J";
            }
            else if (number == 12)
            {
                path = @"Cards\Q";
            }
            else if (number == 13)
            {
                path = @"Cards\K";
            }
            else if (number == 1)
            {
                path = @"Cards\A";
            }
            else
            {
                path = @"Cards\" + Convert.ToString(number);
            }
            path += Convert.ToString(suit) + @".png";

            img = new Bitmap(path);

            return img;
        }

        public Card DealCard()
        {
            if (cards.Count == 0)
            {
                ShuffleCards();
            }

            return (Card)cards.Dequeue();
        }

        private void ShuffleCards()
        {
            MessageBox.Show("Shuffling");

            for (int numDiscard = discard.Count; numDiscard > 0; numDiscard--)
            {
                int rand = randGen.Next(0, numDiscard);

                cards.Enqueue(discard[rand]);
                discard.RemoveAt(rand);
            }

            foreach (Card card in cards)
            {
                Console.WriteLine(card.numericalValue);
            }
        }

        public void Discard(Card card)
        {
            discard.Add(card);
        }
    }
}
