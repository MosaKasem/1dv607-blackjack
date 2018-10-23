using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model.rules
{
    class AmericanNewGameStrategy : GameStrategy
    {
        override bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
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

            c = a_deck.GetCard();
            c.Show(false);
            a_dealer.DealCard(c);

            return true; */
        }
    }
}
