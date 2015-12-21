using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SoftUniWarz.Background;
using SoftUniWarz.Buttons;
using SoftUniWarz.Content;
using SoftUniWarz.Attack.PlayerAttacks;
using SoftUniWarz.Attack;

namespace SoftUniWarz.States
{
    class LevelTwoState : LevelOneState
    {
        public LevelTwoState(ContentManager content, Vector2 screenSize) 
            : base(screenSize)
        {
            base.content = content;
            base.player = new NovicePlayer("Nasko");
            base.enemy = new FirstLevelEnemy();
            base.staticElements.Add(new GUIelements("arenaBG", new Vector2(0, 0), (int)screenSize.X, (int)screenSize.Y));
            buttons.Add(new Button(Buttons.Buttons.BinaryBtn, new Vector2(screenSize.X / 2 - 100, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
            buttons.Add(new Button(Buttons.Buttons.BookBtn, new Vector2(screenSize.X / 2, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
            buttons.Add(new Button(Buttons.Buttons.TermBtn, new Vector2(screenSize.X /2 + 100, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
        }
        public LevelTwoState(Vector2 screenSize)
            :base(screenSize)
        {
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            foreach (var guiElements in buttons)
            {
                guiElements.LoadContent(content);
                guiElements.ClickEvent += OnClick;
            }
        }

        public override void OnClick(string element)
        {
            base.OnClick(element);
            if (base.isPlayerMove)
            {
                Vector2 positionForMagic = new Vector2(player.Element.Position.X + player.Element.GUIrect.Width / 2,
               player.Element.Position.Y + player.Element.GUIrect.Height / 2);
                if (element == Buttons.Buttons.TermBtn.ToString())
                {
                    TermosThrowAttack attack = new TermosThrowAttack(positionForMagic);
                    player.ProduceAttack(attack);
                    isPlayerMove = false;
                }
            }

        }

        public override void Update()
        {
            if (this.enemy.HealthPoints <= 0)
            {
                StateManager.ChangeToState(GameStates.LevelThreeState);
            }
            base.Update();
        }
    }
}
