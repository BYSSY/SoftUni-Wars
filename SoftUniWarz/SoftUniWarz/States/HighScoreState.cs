using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SoftUniWarz.Background;
using SoftUniWarz.Content;

namespace SoftUniWarz.States
{
    public class HighScoreState : State
    {

        private SpriteFont spriteFont;
        private SortedDictionary<int, string> dataDictionary;
        private HighScore highScore;
        private List<GUIelements> elements = new List<GUIelements>();

        public HighScoreState(Vector2 screenSize)
            : base(screenSize)
        {
            highScore = new HighScore();
            dataDictionary = highScore.Read();
            elements.Add(new GUIelements("HSBG", new Vector2(0, 0), 1366, 768));
            elements.Add(new GUIelements("HS",new Vector2(433,30),500,175));


        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            foreach (var element in elements)
            {
                element.Draw(spriteBatch);
            }
            int y = 200;
            foreach (var entry in dataDictionary.Reverse())
            {
                spriteBatch.DrawString(spriteFont, entry.Key + "", new Vector2(100, y), Color.AliceBlue);
                spriteBatch.DrawString(spriteFont, entry.Value, new Vector2(140, y), Color.AliceBlue);
                y += 50;
            }


        }

        public override void Update()
        {
            foreach (var element in elements)
            {
                element.Update();
            }
        }

        public override void LoadContent(ContentManager content)
        {
            spriteFont = content.Load<SpriteFont>("MyFont");
            foreach (var element in elements)
            {
                element.LoadContent(content);
            }
        }




    }
}
