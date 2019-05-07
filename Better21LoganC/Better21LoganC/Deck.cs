using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Resources;

namespace Better21LoganC
{
    public struct Card
    {
        public Image cardImage;
        public int numericalValue;
        public char suit;

        public Card(Image img, int number, char suitChar)
        {
            cardImage = img;
            numericalValue = number;
            suit = suitChar;
        }
    }

    class Deck
    {
        private Queue cards;
        private List<Card> discard;
        private Random randGen = new Random();
        private enum Suits
        {
            CLUB, HEART, SPADE, DIAMOND
        }
        
        Card 

        public Deck()
        {
            for (int suitNumber = 0; suitNumber < 4; suitNumber++)
            {
                Suits suit = (Suits)suitNumber;

                for (int numberValue = 1; numberValue <= 13; numberValue++)
                {
                   

                    


                }
            }
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
            for (int numDiscard = discard.Count; numDiscard > 0; numDiscard--)
            {
                int rand = randGen.Next(0, numDiscard);

                cards.Enqueue(discard[rand]);
                discard.RemoveAt(rand);
            }
        }

        public void Discard(Card card)
        {
            discard.Add(card);
        }
    }
}
