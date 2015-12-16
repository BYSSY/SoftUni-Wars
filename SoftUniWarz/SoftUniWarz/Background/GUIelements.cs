using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SoftUniWarz.Background
{
    public class GUIelements
    {
        private Texture2D GUItexture;
        private Rectangle gUIrect;
        private string elementName;



        public GUIelements(string elementName)
        {
            this.ElementName = elementName;
        }

        public string ElementName
        {
            get { return this.elementName; }
            set { this.elementName = value; }
        }

        public Rectangle GUIrect
        {
            get
            {
                return gUIrect;
            }

            set
            {
                gUIrect = value;
            }
        }

        public void LoadContent(ContentManager content)
        {
            GUItexture = content.Load<Texture2D>(elementName);
            GUIrect= new Rectangle(0,0,GUItexture.Width,GUItexture.Height);
        }

        public virtual void Update()
        {
          
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(GUItexture,GUIrect,Color.White);
        }

        public void CenterElement(int height, int width)
        {
            GUIrect = new Rectangle((width/2)-(this.GUIrect.Width/2),(height/2)-(this.GUIrect.Height/2),this.GUItexture.Width,this.GUItexture.Height);
        }

        public void MoveElement(int x , int y)
        {
            GUIrect = new Rectangle(gUIrect.X+=x, gUIrect.Y+=y,GUIrect.Width,GUIrect.Height);
        }
    }
}
