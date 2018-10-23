﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model.rules
{
    interface INewGameStrategy
    {
        bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player);
    }
    abstract class GameStrategy : INewGameStrategy
    {
        public abstract bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player);
        public void DealCard(Deck a_deck, Player a_player, bool show = true)
        {
            Card c;
            c = a_deck.GetCard();
            c.Show(true);
            a_player.DealCard(c);
        }
    }
}
