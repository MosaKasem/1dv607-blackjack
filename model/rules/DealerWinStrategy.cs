using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model.rules
{
    class DealerWinStrategy : IGameWinnerStrategy
    {
        public bool IsDealerWinner(Dealer a_dealer, Player a_player, int maxScore)
        {

            if (a_player.CalcScore() > maxScore)
            {
                return true;
            }
            else if (a_dealer.CalcScore() > maxScore)
            {
                return false;
            }
            return a_dealer.CalcScore() >= a_player.CalcScore();
        }
    }
}