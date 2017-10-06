using Shithead;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitheadConsole
{
    public class ConsoleView : IShitheadView
    {
        public ConsoleView()
        {

        }

        public IShitheadPresenter Presenter
        {
            get;
            set;
        }

        public void ShowDeck()
        {
            Console.WriteLine("Deck:\n");
            Console.WriteLine(Presenter.Deck);
        }

        public void ShowHands()
        {
            for (int i = 0; i < Presenter.NumberOfPlayers; i++)
            {
                Console.WriteLine("Hand " + i + ": \n");
                Console.WriteLine(Presenter.Hands[i]);
            }
        }

        public void ShowInConsole(string str)
        {
            Console.WriteLine(str);
        }

        public void GiveInstruction(string str)
        {
            ShowInConsole(str);
        }

        public void WaitForResponse()
        {

        }
    }
}
