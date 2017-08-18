using DougieMcDungeons.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DougieMcDungeons
{
    public partial class Form1 : Form
    {
        private char? moveDirection = null;
        public Game theGame = new Game();
        public delegate void UpdateFormDelegate(int operation, string message);

        public Form1()
        {
            InitializeComponent();
            UpdateForm.OnNewFormEvent += UpdateFormEvent_OnNewFormEvent;
            movementTimer.Interval = 200;
            movementTimer.Start();         
            coordinatesLabel.DataBindings.Add("Text", theGame, "coordinates", true, DataSourceUpdateMode.OnPropertyChanged);
            skillPicturesUpdate();
            UpdateFormEvent_OnNewFormEvent(2, "Your journey begins!");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            for (int x = 0; x < 17; x++)
            {
                for (int y = 0; y < 17; y++)
                {
                    e.Graphics.DrawImage(theGame.activeMap.returnImage((theGame.playerX - 8 + x), (theGame.playerY - 8 + y)), theGame.map[x, y]);
                    for (int i = 0; i < theGame.enemyLocs.Count; i++)
                    {
                        if (theGame.enemyLocs[i].X == (theGame.playerX - 16 + x) && theGame.enemyLocs[i].Y == (theGame.playerY - 16 + y))
                        {
                            e.Graphics.DrawImage(theGame.activeMap.enemiesOnMap[i].img, theGame.map[(16 - theGame.playerX + theGame.enemyLocs[i].X), (16 - theGame.playerY + theGame.enemyLocs[i].Y)]);
                        }
                    }
                }
            }
            e.Graphics.DrawImage(Properties.Resources.player2, theGame.map[8, 8]);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;//We do what we please with our key presses! (no really, cancel any undesired effects such as textbox scrolling with S key)
            if (!theGame.inBattle)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        moveDirection = 'W';
                        break;
                    case Keys.A:
                        moveDirection = 'A';
                        break;
                    case Keys.S:
                        moveDirection = 'S';
                        break;
                    case Keys.D:
                        moveDirection = 'D';
                        break;
                    case Keys.X:
                        moveDirection = null;
                        break;
                }
            }
            else if (theGame.inBattle)
            {
                switch (e.KeyCode)
                {
                    case Keys.D0:
                        theGame.battleTurn(0);
                        break;
                    case Keys.D1:
                        theGame.battleTurn(1);
                        break;
                    case Keys.D2:
                        theGame.battleTurn(2);
                        break;
                    case Keys.D3:
                        theGame.battleTurn(3);
                        break;
                    case Keys.D4:
                        theGame.battleTurn(4);
                        break;
                    case Keys.D5:
                        theGame.battleTurn(5);
                        break;
                    case Keys.D6:
                        theGame.battleTurn(6);
                        break;
                    case Keys.D7:
                        theGame.battleTurn(7);
                        break;
                    case Keys.D8:
                        theGame.battleTurn(8);
                        break;
                    case Keys.D9:
                        theGame.battleTurn(9);
                        break;
                }
            }
        }

        private void movementTimer_Tick(object sender, EventArgs e)
        {
            if (moveDirection != null)
            {
                theGame.playerMove(moveDirection);
            }
            Invalidate();
        }

        public void UpdateFormEvent_OnNewFormEvent(int operation, string message)
        {
            if (operation == 1)
            {
                updateMessageBox(message);
            }
            else if (operation == 2)
            {
                mapLabel.Text = "Current Map: " + theGame.activeMap.mapsName;
                moveDirection = null;
                playerLabelUpdate();
                updateMessageBox(message);
            }
            else if(operation == 3)
            {
                movementTimer.Start();
                playerEquipLabelUpdate();
                playerLabelUpdate();
            }
            else if(operation == 4)
            {
                updateMessageBox(message);
                moveDirection = null;
                movementTimer.Stop();
            }
            else if (operation == 5)
            {
                //updateMessageBox(message);
                //moveDirection = null;
                movementTimer.Start();
                skillPicturesUpdate();
            }
        }

        private void playerLabelUpdate()
        {
            healthLabel.Text = "Health: " + theGame.player.totalStats["hp"] + " / " + theGame.player.totalStats["maxhp"];
            atkLabel.Text = "ATK: " + theGame.player.totalStats["atk"];
            matkLabel.Text = "MATK: " + theGame.player.totalStats["matk"];
            defLabel.Text = "DEF: " + theGame.player.totalStats["def"];
            mdefLabel.Text = "MDEF: " + theGame.player.totalStats["mdef"];
            atkcritLabel.Text = "ATK Crit: " + theGame.player.totalStats["atkcrit"];
            matkcritLabel.Text = "MATK Crit: " + theGame.player.totalStats["matkcrit"];
            atkhitLabel.Text = "ATK Hit: " + theGame.player.totalStats["atkhit"];
            matkhitLabel.Text = "MATK Hit: " + theGame.player.totalStats["matkhit"];
        }

        private void playerEquipLabelUpdate()
        {
            headLabel.Text = (theGame.player.head == null) ? headLabel.Text = "None" : headLabel.Text = theGame.player.head.name;
            chestLabel.Text = (theGame.player.chest == null) ? chestLabel.Text = "None" : chestLabel.Text = theGame.player.chest.name;
            handsLabel.Text = (theGame.player.hands == null) ? handsLabel.Text = "None" : handsLabel.Text = theGame.player.hands.name;
            legsLabel.Text = (theGame.player.legs == null) ? legsLabel.Text = "None" : legsLabel.Text = theGame.player.legs.name;
            feetLabel.Text = (theGame.player.feet == null) ? feetLabel.Text = "None" : feetLabel.Text = theGame.player.feet.name;
            weaponLabel.Text = (theGame.player.weapon == null) ? weaponLabel.Text = "None" : weaponLabel.Text = theGame.player.weapon.name;
        }

        private void updateMessageBox(string msg)
        {
            messageBox.Items.Insert(0, msg);
            if (messageBox.Items.Count > 25)
            {
                messageBox.Items.RemoveAt(25);
            }
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            if (!theGame.inBattle)
            {
                movementTimer.Stop();
                moveDirection = null;
                Inventory inventory = new Inventory(theGame.player);
                inventory.Show();
            }
        }

        private void skillPicturesUpdate()
        {
            skill0Picture.Image = (theGame.player.skillSet[0].name == "None") ? Properties.Resources.noSkill : theGame.player.skillSet[0].img;
            skill1Picture.Image = (theGame.player.skillSet[1].name == "None") ? Properties.Resources.noSkill : theGame.player.skillSet[1].img;
            skill2Picture.Image = (theGame.player.skillSet[2].name == "None") ? Properties.Resources.noSkill : theGame.player.skillSet[2].img;
            skill3Picture.Image = (theGame.player.skillSet[3].name == "None") ? Properties.Resources.noSkill : theGame.player.skillSet[3].img;
            skill4Picture.Image = (theGame.player.skillSet[4].name == "None") ? Properties.Resources.noSkill : theGame.player.skillSet[4].img;
            skill5Picture.Image = (theGame.player.skillSet[5].name == "None") ? Properties.Resources.noSkill : theGame.player.skillSet[5].img;
            skill6Picture.Image = (theGame.player.skillSet[6].name == "None") ? Properties.Resources.noSkill : theGame.player.skillSet[6].img;
            skill7Picture.Image = (theGame.player.skillSet[7].name == "None") ? Properties.Resources.noSkill : theGame.player.skillSet[7].img;
            skill8Picture.Image = (theGame.player.skillSet[8].name == "None") ? Properties.Resources.noSkill : theGame.player.skillSet[8].img;
            skill9Picture.Image = (theGame.player.skillSet[9].name == "None") ? Properties.Resources.noSkill : theGame.player.skillSet[9].img;
        }

        private void skillsButton_Click(object sender, EventArgs e)
        {
            if (!theGame.inBattle)
            {
                movementTimer.Stop();
                moveDirection = null;
                Skills skills = new Skills(theGame.player);
                skills.Show();
            }
        }

        public static class UpdateForm
        {
            public static event UpdateFormDelegate OnNewFormEvent;

            public static void NewFormEvent(int operation, string message)
            {
                OnNewFormEvent(operation, message);
            }
        }
    }

    public struct Stats
    {
        public string statistic;
        public int magnitude;
        public Stats(string sta, int mag)
        {
            statistic = sta;
            magnitude = mag;
        }
    }

}
