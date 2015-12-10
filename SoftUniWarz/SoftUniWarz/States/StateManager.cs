using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using SoftUniWarz.Background;

namespace SoftUniWarz.States
{
    class StateManager
    {
        private static State currentState;

        internal static State CurrentState
        {
            get { return currentState; }
            private set { currentState = value; }
        }

        public static void ChangeToState(GameState state)
        {
            switch (state)
            {
                case GameState.MainMenu:
                    CurrentState = new MainMenuState();
                    break;
                case GameState.InGame:
                    CurrentState = new InGameState();
                    break;
                case GameState.Quit:
                    CurrentState = new QuitState();
                    break;
                case GameState.PickName:
                    CurrentState = new PickNameState();
                    break;
            }
        }

    }
}
