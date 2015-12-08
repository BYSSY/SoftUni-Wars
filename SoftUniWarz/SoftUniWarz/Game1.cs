using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SoftUniWarz.Background;

namespace SoftUniWarz
{
   
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private BackgroundSprite mainMenuBackground;
        private MainMenuButtons btnPlay;
        private enum GameState
        {
            MainMenu,
            Playing
        }

        GameState currentState = GameState.MainMenu;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferHeight = 600;
            graphics.PreferredBackBufferWidth = 800;
            graphics.ApplyChanges();
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
            mainMenuBackground=new BackgroundSprite(Content.Load<Texture2D>("classroom"),new Vector2(0,0));

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


            btnPlay=new MainMenuButtons(Content.Load<Texture2D>("play"),graphics.GraphicsDevice);
            btnPlay.SetPosition(new Vector2(350,300));

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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            MouseState mouse = Mouse.GetState();

            switch (currentState)
            {
                case GameState.MainMenu:
                    if (btnPlay.isClicked==true)
                    {
                        currentState=GameState.Playing;
                        btnPlay.Update(mouse);
                    }
                    break;
                case GameState.Playing:
                    break;
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);


            spriteBatch.Begin();
            switch (currentState)
            {
                case GameState.MainMenu:
                    mainMenuBackground.Draw(spriteBatch);

                    btnPlay.Draw(spriteBatch);
                    break;
                case GameState.Playing:
                    break;
            }


            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
