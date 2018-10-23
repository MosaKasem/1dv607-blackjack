using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model.rules
{
    class InternationalNewGameStrategy : GameStrategy
    {
        override public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            DealCard(a_deck, a_player);
            DealCard(a_deck, a_dealer);
            DealCard(a_deck, a_player);
            return true;
/*             Card c;

            c = a_deck.GetCard();
            c.Show(true);
            a_player.DealCard(c);

            c = a_deck.GetCard();
            c.Show(true);
            a_dealer.DealCard(c);

            c = a_deck.GetCard();
            c.Show(true);
            a_player.DealCard(c);

            return true; */
        }
    }
}
