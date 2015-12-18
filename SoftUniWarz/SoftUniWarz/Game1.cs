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

    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        public static bool isInitialized = false;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private TimeSpan frame;
        private bool printFrame;
        

        public Game1()
        {
            frame = new TimeSpan();
            printFrame = false;
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            StateManager.Content = Content;
            graphics.PreferredBackBufferWidth = 1366;
            graphics.PreferredBackBufferHeight = 768;
            StateManager.ChangeToState(GameState.MainMenu);
            IsMouseVisible = true;

            //TEST
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            isInitialized = true;
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            StateManager.CurrentState.LoadContent(Content);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
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

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
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
