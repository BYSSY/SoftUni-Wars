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
using SoftUniWarz.Characters.Enemy;
using System.Threading;
using SoftUniWarz.Attack.EnemyAttacks;

namespace SoftUniWarz.States
{
    class LevelTwoState : LevelOneState
    {
        
        public LevelTwoState(ContentManager content, Vector2 screenSize) 
            : base(screenSize)
        {
            base.content = content;
            base.player = new NovicePlayer(StateManager.PlayerName);
            base.enemy = new SecondLevelEnemy();
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
                StateManager.ChangeToState(StateManager.GetNextState());
                return;
            }
            if (playerHasHit && !isPlayerMove)
            {
                Vector2 positionForMagic = new Vector2(enemy.Element.Position.X + enemy.Element.GUIrect.Width / 2,
               enemy.Element.Position.Y + enemy.Element.GUIrect.Height / 2);
                Random rnd = new Random();
                Attack.Attack attack = new SnookerBallAttack(positionForMagic);
                if (rnd.Next(0, 2) == 1 && enemy.ManaPoints > attack.ManaCost)
                {
                    Thread.Sleep(2000);
                    enemy.ProduceAttack(attack);
                    playerHasHit = false;
                }
                attack = new RegexAttack(positionForMagic);
                if (rnd.Next(0, 2) == 1 && enemy.ManaPoints > attack.ManaCost && playerHasHit) 
                {
                    Thread.Sleep(2000);
                    enemy.ProduceAttack(attack);
                    playerHasHit = false;
                }
            }
            base.Update();
        }
    }
}
