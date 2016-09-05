using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Deck
    {
        private List<Card> _cards;
        private Random _random = new Random();
        public int Count { get { return _cards.Count; } }

        public Deck()
        {
            _cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    _cards.Add(new Card((Values)value, (Suits)suit));
        }
        public Card Peek(int cardNumber)
        {
        return _cards[cardNumber];
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            _cards = new List<Card>(initialCards);
        }

        public void Add(Card cardToAdd)
        {
            _cards.Add(cardToAdd);
        }

        public Card Deal()
        {
            return Deal(0);
        }

        public Card Deal(int index)
        {
            Card cardToDeal = _cards[index];
            _cards.RemoveAt(index);
            return cardToDeal;
        }

        public void Shuffle()
        {
            List<Card> newCards = new List<Card>();
            while (_cards.Count > 0)
            {
                int cardToMove = _random.Next(_cards.Count);
                newCards.Add(_cards[cardToMove]);
                _cards.RemoveAt(cardToMove);
            }
            _cards = newCards;
        }

        public Deck PullOutValues(Values value)
        {
            Deck decktoReturn = new Deck(new Card[] { });
            for (int i = _cards.Count - 1; i >= 0; i--)
                if (_cards[i].Value == value)
                    decktoReturn.Add(Deal(i));
            return decktoReturn;
        }

        public IEnumerable<string> GetCardNames()
        {
            string[] cardNames = new string[_cards.Count];
            for (int i = 0; i < _cards.Count; i++)
                cardNames[i] = _cards[i].Name;
            return cardNames;
        }

        public void SortBySuit()
        {
            _cards.Sort(new CardComparer_bySuit());
        }

        public void SortByValue()
        {
            _cards.Sort(new CardComparer_byValue());
        }

        public bool ContainsValue (Values value)
        {
            foreach (Card card in _cards)
                if (card.Value == value)
                    return true;
            return false;
        }

        public bool HasBook(Values value)
        {
            int numberofCards = 0;
            foreach (Card card in _cards)
                if (card.Value == value)
                    numberofCards++;
            if (numberofCards == 4)
                return true;
            else
                return false; 
        }
    }
}
