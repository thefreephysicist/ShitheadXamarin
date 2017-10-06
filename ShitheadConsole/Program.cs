using Shithead;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitheadConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IShitheadModel _model = new ShitheadModel();
            IShitheadView _view = new ConsoleView();
            int numOfPlayers = 2;

            Console.WriteLine("Working");
            Game game = new Game(_view, _model, numOfPlayers);
            game.WriteCurrentState();
            Console.ReadLine();
        }
    }
}
