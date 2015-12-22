using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SoftUniWarz.Attack.PlayerAttacks;
using SoftUniWarz.Background;
using Microsoft.Xna.Framework;
using SoftUniWarz.Buttons;
using SoftUniWarz.Content;

namespace SoftUniWarz.States
{
    class LevelOneState : LevelState
    {
        //Here should be the main logic and the instatiation of Game1


        public LevelOneState(ContentManager content, Vector2 screenSize)
            : base(screenSize)
        {
            base.content = content;
            base.player = new NovicePlayer(StateManager.PlayerName);
            base.enemy = new FirstLevelEnemy();
            base.staticElements.Add(new GUIelements("arenaBG", new Vector2(0, 0), (int)screenSize.X, (int)screenSize.Y));
            buttons.Add(new Button(Buttons.Buttons.BinaryBtn, new Vector2(screenSize.X/2, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
            buttons.Add(new Button(Buttons.Buttons.BookBtn, new Vector2(screenSize.X / 2 - 100, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
        }

        public LevelOneState(Vector2 screenSize)
            :base(screenSize)
        { }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            foreach (var guiElements in buttons)
            {
                guiElements.LoadContent(content);
                guiElements.ClickEvent += OnClick;
            }
        }

        public virtual void OnClick(string element)
        {
            if (base.isPlayerMove)
            {
                Vector2 positionForMagic = new Vector2(player.Element.Position.X + player.Element.GUIrect.Width / 2,
               player.Element.Position.Y + player.Element.GUIrect.Height / 2);
                if (element == Buttons.Buttons.BinaryBtn.ToString())
                {
                    BinaryAttack attack = new BinaryAttack(positionForMagic);
                    player.ProduceAttack(attack);
                    isPlayerMove = false;
                }
                if (element == Buttons.Buttons.BookBtn.ToString())
                {
                    CSharpBookAttack attack = new CSharpBookAttack(positionForMagic);
                    player.ProduceAttack(attack);
                    isPlayerMove = false;
                }
            }

        }

        public override void Update()
        {
            if (this.enemy.HealthPoints <= 0)
            {
                StateManager.ChangeToState(StateManager.GetNextState());

                return;
            }
            base.Update();
        }
    }
}
