﻿using System;
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
            base.player = new NovicePlayer("Nasko");
            base.enemy = new FirstLevelEnemy();
            base.staticElements.Add(new GUIelements("arenaBG", new Vector2(0, 0), (int)screenSize.X, (int)screenSize.Y));
            buttons.Add(new Button("BinaryBtn", new Vector2(screenSize.X/2, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
            buttons.Add(new Button("BookBtn", new Vector2(screenSize.X / 2 - 100, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

        public override void Update()
        {
            //if (player.HealthPoints <= 0)
            //{
            //    StateManager.ChangeToState(GameState.MainMenu);
            //    //TODO: save highscore
            //}
            //if (enemy.HealthPoints <= 0)
            //{
            //    StateManager.ChangeToState(GameState.LevelTwoState);
            //}
            base.Update();
        }

        public override void LoadContent(ContentManager content)
        {
           base.LoadContent(content);
        }
        

    }
}
