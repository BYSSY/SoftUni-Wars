using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SoftUniWarz.Background;
using SoftUniWarz.States;

namespace SoftUniWarz
{

    public class UnSeriousEngine : Game
    {
        public static bool isInitialized = false;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private TimeSpan frame;
        private bool printFrame;
    
        public UnSeriousEngine()
        {
            frame = new TimeSpan();
            printFrame = false;
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            StateManager.Content = Content;
            graphics.PreferredBackBufferWidth = 1366;
            graphics.PreferredBackBufferHeight = 768;
            StateManager.ChangeToState(GameStates.MainMenu);
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            isInitialized = true;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            StateManager.CurrentState.LoadContent(this.Content);
        }

        protected override void UnloadContent()
        {
            //Implement unload content
        }

        protected override void Update(GameTime gameTime)
        {
            frame += gameTime.ElapsedGameTime;
            if (frame.CompareTo(new  TimeSpan(0, 0, 0,0 ,30)) == 1)
            {
                Debug.Print(frame.TotalMilliseconds + "");
                frame = new TimeSpan();
                printFrame = true;
                StateManager.CurrentState.Update();
                base.Update(gameTime);
            }
          
        }
       
        protected override void Draw(GameTime gameTime)
        {
            if (printFrame)
            {
                GraphicsDevice.Clear(Color.CornflowerBlue);
                spriteBatch.Begin();

                StateManager.CurrentState.Draw(spriteBatch);

                spriteBatch.End();

                base.Draw(gameTime);
                printFrame = false;
            }
        }

        
    }
}
