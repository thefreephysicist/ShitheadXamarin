using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Shithead
{
    public class Game : IShitheadPresenter
    {
        public IShitheadModel Model
        {
            get;
            set;
        }

        public IShitheadView View
        {
            get;
            set;
        }

        public List<ShitHand> Hands
        {
            get
            {
                return Model.Hands;
            }
            set
            {
                Model.Hands = value;
            }
        }

        public Deck Deck
        {
            get
            {
                return Model.Deck;
            }
            set
            {
                Model.Deck = value;
            }
        }

        public Pile Pile
        {
            get
            {
                return Model.Pile;
            }
            set
            {
                Model.Pile = value;
            }
        }

        public int NumberOfPlayers
        {
            get
            {
                return _numOfPlayers;
            }
        }

        private int _numOfPlayers = -1;
        private const int _numOfCardsInHand = 3;

        public Game(IShitheadView view, IShitheadModel model,  int numOfPlayers)
        {
            int cardCount = 3;

            Model = model;
            View = view;

            _numOfPlayers = numOfPlayers;
            Deck = new Deck(52);
            Pile = new Pile();
            Hands = new List<ShitHand>(numOfPlayers);
            for (int i = 0; i < numOfPlayers; i++)
            {
                Hands.Add(new ShitHand(cardCount, Deck, Pile));
            }
        }

        public string GetPrintOut()
        {
            string str = string.Empty;

            for (int i = 0; i < Hands.Count; i++)
            {
                str += "Hand " + i + ":\n";
                str += Hands[i];
            }

            str += "The deck:\n";
            str += Deck;
            return str;
        }

        public void WriteCurrentState()
        {
            View.ShowInConsole(GetPrintOut());
        } 

        public void RunGame()
        {
            while(true)
            {
                for (int i = 0; i < _numOfPlayers; i++)
                {
                    View.GiveInstruction("Player " + i + ", play a card");
                    
                }
            }   
        }

        public void WaitForCardPlay()
        {

        }
    }
}