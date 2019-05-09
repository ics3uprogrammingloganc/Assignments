using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better21LoganC
{
    public abstract class Player
    {
        private List<Card> hand = new List<Card>();
        private int _score = 0;
        Deck deckPointer;

        abstract public void StartTurn();
        public int Score
        {
            get
            {
                return _score;
            }           
        }
    }
}
