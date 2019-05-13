// Better21 by Logan Cantin
// Card struct and Deck class

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
    // Struct to hold all card related information (Images, numeric value, suit, etc)
    public struct Card
    {
        // Public variables
        public Image cardImage;
        public int numericalValue;
        public char suit;
        static public Image backImage = new Bitmap(@"Cards\purple_back.png"); //Static variable because each card has the same back
        public static Size cardSize = new Size(70, 100); //Static because all cards are the same size, to create new pictureboxes.

        // Constructor takes card image, value, and suit
        public Card(Image img, int number, char suitChar)
        {
            cardImage = img;
            numericalValue = (number < 10) ? number : 10;
            suit = suitChar;
        }
    }

    // Deck class supports all deck actions like dealing, discard, shuffling, etc
    public class Deck
    {
        // Private variables
        private Queue<Card> cards = new Queue<Card>(); // Queue containing all cards to de dealt
        private List<Card> discard = new List<Card>(); // List containing all discarded cards, to be shuffled into the deck
        private Random randGen = new Random(); // Random number generator to shuffle the cards

        // Constructor takes no arguments.
        // Generates all cards and shuffles them
        public Deck()
        {
            // Generating all cards and adding them to discard
            foreach (char suit in "SHDC")
            {
                for (int numberValue = 1; numberValue <= 13; numberValue++)
                {
                    Image cardImage = GetCardImage(suit, numberValue);

                    Card newCard = new Card(cardImage, numberValue, suit);

                    discard.Add(newCard);
                }
            }

            //Shuffle cards, putting them in the deck.
            ShuffleCards();
        }

        // Programmatically fetches images from an image file to be used on the cards
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

        // Takes one card from the front of the queue and gives it to the user.
        public Card DealCard()
        {
            // If there are no more cards to give, shuffle the discard pile into the deck
            if (cards.Count == 0)
            {
                ShuffleCards();
            }

            return (Card)cards.Dequeue();
        }

        //Shuffles cards from discard and places them in the deck
        private void ShuffleCards()
        {
            // Alerting the user that their deck is being shuffled.
            MessageBox.Show("Shuffling");

            // Take random cards from the discard pile and enqueue them in the deck
            for (int numDiscard = discard.Count; numDiscard > 0; numDiscard--)
            {
                int rand = randGen.Next(0, numDiscard);

                cards.Enqueue(discard[rand]);
                discard.RemoveAt(rand);
            }
        }

        // Takes a card from the user and adds it to the discard pile
        public void Discard(Card card)
        {
            discard.Add(card);
        }

        // Function used by the AIs to determine value of the next card
        public int Peek()
        {
            // Shuffle cards if there are no more left
            if (cards.Count == 0)
            {
                ShuffleCards();
            }
            
            // Determine and return the numeric value of the top card
            Card topCard = cards.Peek();
            return topCard.numericalValue;
        }
    }
}
