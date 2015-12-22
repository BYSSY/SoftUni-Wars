using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using SoftUniWarz.GUIElements;
using SoftUniWarz.Buttons;
using SoftUniWarz.Content;
using SoftUniWarz.Attack;
using SoftUniWarz.Attack.PlayerAttacks;
using SoftUniWarz.Characters.Enemy;
using SoftUniWarz.Attack.EnemyAttacks;
using System.Threading;

namespace SoftUniWarz.States
{
    class FinalLevel : LevelThreeState
    {
        public FinalLevel(ContentManager content, Vector2 screenSize)
            : base(screenSize)
        {
            base.content = content;
            base.player = new NovicePlayer(StateManager.PlayerName);
            base.enemy = new FinalBoss();
<<<<<<< HEAD
            base.staticElements.Add(new GUIelement("arenaBG", new Vector2(0, 0), (int)screenSize.X, (int)screenSize.Y));
            buttons.Add(new Button(Buttons.Buttons.BinaryBtn, new Vector2(screenSize.X / 2 - 100, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
            buttons.Add(new Button(Buttons.Buttons.BookBtn, new Vector2(screenSize.X / 2, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
            buttons.Add(new Button(Buttons.Buttons.CtorBtn, new Vector2(screenSize.X / 2 + 200, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
            buttons.Add(new Button(Buttons.Buttons.TermBtn, new Vector2(screenSize.X / 2 + 100, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
            buttons.Add(new Button(Buttons.Buttons.BeerBtn, new Vector2(screenSize.X / 2 + 300, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
            buttons.Add(new Button(Buttons.Buttons.ReSharperBtn, new Vector2(screenSize.X / 2 + 400, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
=======
            base.staticElements.Add(new GUIelements("arenaBG", new Vector2(0, 0), (int)screenSize.X, (int)screenSize.Y));
            buttons.Add(new Button(Buttons.Buttons.BinaryBtn, new Vector2(screenSize.X / 2 - 250, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
            buttons.Add(new Button(Buttons.Buttons.BookBtn, new Vector2(screenSize.X / 2-150, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
            buttons.Add(new Button(Buttons.Buttons.CtorBtn, new Vector2(screenSize.X / 2 + 50, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
            buttons.Add(new Button(Buttons.Buttons.TermBtn, new Vector2(screenSize.X / 2 -50, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
            buttons.Add(new Button(Buttons.Buttons.BeerBtn, new Vector2(screenSize.X / 2 + 150, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
            buttons.Add(new Button(Buttons.Buttons.ReSharperBtn, new Vector2(screenSize.X / 2 + 250, 650), Prefabs.standardInGameButtonSize, Prefabs.standardInGameButtonSize));
>>>>>>> 02c9a067597ed0640f04c0d5e8ff97efcb4f4444
        }

        public FinalLevel(Vector2 screenSize)
            : base(screenSize)
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
                if (element == Buttons.Buttons.BeerBtn.ToString())
                {
                    BeerAttack attack = new BeerAttack(positionForMagic);
                    player.ProduceAttack(attack);
                    isPlayerMove = false;
                }
                if (element == Buttons.Buttons.ReSharperBtn.ToString())
                {
                    ResharperAttack attack = new ResharperAttack(positionForMagic);
                    player.ProduceAttack(attack);
                    isPlayerMove = false;
                }
            }
        }

        public override void Update()
        {
            if (enemy.HealthPoints <= 0)
            {
                StateManager.ChangeToState(StateManager.GetNextState());

                //TODO write Score
                return;
            }
            if (playerHasHit && !isPlayerMove)
            {
                Vector2 positionForMagic = new Vector2(enemy.Element.Position.X + enemy.Element.GUIrect.Width / 2,
               enemy.Element.Position.Y + enemy.Element.GUIrect.Height / 2);
                Random rnd = new Random();
                Attack.Attack attack = new ErrorAttack(positionForMagic);
                if (rnd.Next(0, 2) == 1 && enemy.ManaPoints > attack.ManaCost)
                {
                    Thread.Sleep(2000);
                    enemy.ProduceAttack(attack);
                    playerHasHit = false;
                }
                attack = new GraphAttack(positionForMagic);
                if (rnd.Next(0, 2) == 1 && enemy.ManaPoints > attack.ManaCost && playerHasHit)
                {
                    Thread.Sleep(2000);
                    enemy.ProduceAttack(attack);
                    playerHasHit = false;
                }
                attack = new LambdaAttack(positionForMagic);
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
