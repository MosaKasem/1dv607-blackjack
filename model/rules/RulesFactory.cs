using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model.rules
{
    class RulesFactory
    {
        public IHitStrategy GetHitRule()
        {
            // return new BasicHitStrategy();
            return new Soft17HitStrategy();
        }

        public INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }
        public IGameWinnerStrategy GetGameWinnerStrategy()
        {
            return "bla";
        }
    }
}
