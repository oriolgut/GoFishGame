using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    class Player
    {
        private string _name;
        private Random _random;
        private Deck _cards;
        private TextBox _textBoxOnForm;

        public string Name { get { return _name; } }
        public int CardCount { get { return _cards.Count; } }

        public Player(string name, Random random, TextBox textBoxOnForm)
        {
            _name = name;
            _random = random;
            _cards = new Deck(new Card[] { });
            _textBoxOnForm = textBoxOnForm;
            _textBoxOnForm.Text += Name + " has just joined the game." + Environment.NewLine;
        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < _cards.Count; card++)
                    if (_cards.Peek(card).Value == value)
                        howMany++;
                if (howMany == 4)
                {
                    books.Add(value);
                    _cards.PullOutValues(value);
                }
            }
            return books;
        }

        public Values GetRandomValue()
        {
            Card randomCard = _cards.Peek(_random.Next(_cards.Count));
            return randomCard.Value;
        }

        public Deck DoYouHaveAny(Values value)
        {
            Deck cardsIHave = _cards.PullOutValues(value);
            _textBoxOnForm.Text += Name + " has " + cardsIHave.Count + Card.Plural(value) + Environment.NewLine;
            return cardsIHave;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            if (stock.Count > 0)
            {
                if (_cards.Count == 0)
                    _cards.Add(stock.Deal());
                Values randomValue = GetRandomValue();
                AskForACard(players, myIndex, stock, randomValue);
                if (stock.Count > 0 && players[0].CardCount == 0)
                    players[0]._cards.Add(stock.Deal());
            }
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            _textBoxOnForm.Text += Name + " asks if anyone has a " + value + Environment.NewLine;
            int totalCardsGiven = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Player player = players[i];
                    Deck CardsGiven = player.DoYouHaveAny(value);
                    totalCardsGiven += CardsGiven.Count;
                    while (CardsGiven.Count > 0)
                        _cards.Add(CardsGiven.Deal());
                }
            }
            if (totalCardsGiven == 0 && stock.Count > 0)
            {
                _textBoxOnForm.Text += Name +
              " must draw from the stock." + Environment.NewLine;
                _cards.Add(stock.Deal());
            }
        }

        public void TakeCard(Card card)
        {
            _cards.Add(card);
        }

        public IEnumerable<string> GetCardNames()
        {
            return _cards.GetCardNames();
        }

        public Card Peek(int cardNumber)
        {
            return _cards.Peek(cardNumber);
        }

        public void SortHand()
        {
            _cards.SortByValue();
        }
    }
}
