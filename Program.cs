using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            model.Game g = new model.Game();
            view.IView v = new view.SwedishView();
            controller.PlayGame ctrl = new controller.PlayGame();
            try
            {
            while (ctrl.Play(g, v));
            }
            catch (Exception Ex)
            {
                WriteLine($"Something's gone horribly wrong!: {Ex.Message}");
            }
        }
    }
}
