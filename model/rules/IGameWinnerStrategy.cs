using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model.rules
{
    interface IGameWinnerStrategy
    {
        bool IsDealerWinner(Dealer a_dealer, Player a_player, int maxScore);
    }
}