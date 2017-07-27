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
        public delegate void UpdateFormDelegate(int operation);

        public Form1()
        {
            InitializeComponent();
            UpdateForm.OnNewFormEvent += UpdateFormEvent_OnNewFormEvent;
            movementTimer.Interval = 200;
            movementTimer.Start();
            UpdateFormEvent_OnNewFormEvent(2);
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

        public void UpdateFormEvent_OnNewFormEvent(int operation)
        {
            if(operation == 1)
            {
                coordinatesLabel.Text = "Coordinates: " + (theGame.playerX - 8).ToString() + ", " + (theGame.playerY - 8).ToString();
            }
            else if (operation == 2)
            {
                coordinatesLabel.Text = "Coordinates: " + (theGame.playerX - 8).ToString() + ", " + (theGame.playerY - 8).ToString();
                mapLabel.Text = "Current Map: " + theGame.activeMap.mapsName;
                moveDirection = null;
            }
        }



        public static class UpdateForm
        {
            public static event UpdateFormDelegate OnNewFormEvent;

            public static void NewFormEvent(int operation)
            {
                OnNewFormEvent(operation);
            }
        }
    }
}
