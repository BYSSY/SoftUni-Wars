using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using SoftUniWarz.Background;

namespace SoftUniWarz.States
{
    class StateManager
    {
        private static State currentState;
        private static ContentManager content;
        public static Vector2 currentScreenSize = new Vector2(1366, 768);

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

        public static void ChangeToState(GameStates state)
        {
            switch (state)
            {
                case GameStates.MainMenu:
                    CurrentState = new MainMenuState(currentScreenSize);
                    break;
                case GameStates.LevelOneState:
                    CurrentState = new LevelOneState(content, currentScreenSize);
                    break;
                case GameStates.LevelTwoState:
                    CurrentState = new LevelTwoState(content, currentScreenSize);
                    break;
                case GameStates.LevelThreeState:
                    CurrentState = new LevelThreeState(content, currentScreenSize);
                    break;
                case GameStates.FinalLevel:
                    CurrentState = new FinalLevel(content, currentScreenSize);
                    break;
                case GameStates.Quit:
                    CurrentState = new QuitState(currentScreenSize);
                    break;
                case GameStates.PickName:
                    CurrentState = new PickNameState(currentScreenSize);
                    break;
                    case GameStates.HighScore:
                    CurrentState = new HighScoreState(currentScreenSize);
                    break;
            }
            if (UnSeriousEngine.isInitialized)
            {
                CurrentState.LoadContent(Content);
            }

        }

    }
}
