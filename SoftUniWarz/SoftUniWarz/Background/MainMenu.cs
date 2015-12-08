using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SoftUniWarz.Background
{
    public class MainMenu
    {
        private List<GUIelements> main = new List<GUIelements>();

        public MainMenu()
        {
            main.Add(new GUIelements("MainMenu"));
            main.Add(new GUIelements("playlogo"));


        }

        public void LoadContent(ContentManager content)
        {
            foreach (var guiElements in main)
            {
                guiElements.LoadContent(content);
                guiElements.CenterElement(768,1366);
                guiElements.clickEvent += OnClick;
            }
            main.Find(x=>x.ElementName=="playlogo").MoveElement(-200,-150);
        }

        public void Update()
        {
            foreach (var guiElement in main)
            {
                guiElement.Update();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var guiElements in main)
            {
                guiElements.Draw(spriteBatch);
            }
        }

        public void OnClick(string element)
        {
            if (element=="playlogo")
            {
                
            }
        }
    }
}
