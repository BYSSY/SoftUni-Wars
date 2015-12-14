﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Xna.Framework.Content;
using SoftUniWarz.Background;

namespace SoftUniWarz.States
{
    class StateManager
    {
        private static State currentState;
        private static ContentManager content;

        public static State CurrentState
        {
            get { return currentState; }
            private set { currentState = value; }
        }

        public static ContentManager Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
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
            if (Game1.isInitialized)
            {
                CurrentState.LoadContent(Content);
            }

        }

    }
}
