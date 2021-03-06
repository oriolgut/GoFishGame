﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class CardComparer_byValue : IComparer<Card>
    {
        public int Compare(Card cardOne, Card cardTwo)
        {
            if (cardOne.Value < cardTwo.Value)
            {
                return -1;      
            }
            if(cardOne.Value > cardTwo.Value)
            {
                return 1;
            }
            if (cardOne.Suit < cardTwo.Suit)
            {
                return -1;
            }
            if(cardOne.Suit > cardTwo.Suit)
            {
                return 1;
            }
            return 0;
        }
    }
}
