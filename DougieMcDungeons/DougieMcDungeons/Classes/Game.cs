using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DougieMcDungeons.Classes
{
    public class Game
    {
        Random rand = new Random();
        public int playerX = 9;
        public int playerY = 38;
        string mapString = null;//Used to hold data to be parsed when a new map is loaded
        public Point[,] map = new Point[17, 17];
        string mapName = "firstmap";
        public Map activeMap = null;// new Map("firstmap");
        public List<Point> mapImageNums = new List<Point>();
        public List<Point> enemyLocs = new List<Point>();
        public List<Point> invalidEnemyLocs = new List<Point>();
        public Player player = new Player();

        public Game()
        {
            loadMap(mapName);
            player.equipmentInventory.Add(new Equipment("Basic Helm[1]"));
            player.equipmentInventory.Add(new Equipment("Basic Helm[1]"));
            player.equipmentInventory.Add(new Equipment("Basic Helm[1]"));
            player.equipmentInventory.Add(new Equipment("Basic Helm[1]"));
            player.essenceInventory.Add(new Essence("Essence of Pumpkin"));
            player.essenceInventory.Add(new Essence("Essence of Gnome"));
            player.essenceInventory.Add(new Essence("Essence of Pumpkin"));

        }

        private void loadMap(string nextMap)
        {
            activeMap = new Map(nextMap);
            for (int x = 0; x < 17; x++)
            {
                for (int y = 0; y < 17; y++)
                {
                    map[x, y] = new Point(200 + (x * 25), 200 + (y * 25));
                }
            }

            invalidEnemyLocs.Clear();
            enemyLocs.Clear();
            for (int i = 0; i < activeMap.enemiesOnMap.Count; i++)
            {
                Point P = new Point(rand.Next(0, (activeMap.xLength - 16)), rand.Next(0, (activeMap.yLength - 16)));
                if (!invalidEnemyLocs.Contains(P) && (activeMap.mapImageNums[P.Y + 8][P.X + 8] == "003" || activeMap.mapImageNums[P.Y + 8][P.X + 8] == "002" || activeMap.mapImageNums[P.Y + 8][P.X + 8] == "001"))
                {
                    enemyLocs.Add(P);
                    invalidEnemyLocs.Add(new Point(P.X, P.Y));
                    invalidEnemyLocs.Add(new Point(P.X - 1, P.Y - 1));
                    invalidEnemyLocs.Add(new Point(P.X - 1, P.Y + 1));
                    invalidEnemyLocs.Add(new Point(P.X + 1, P.Y - 1));
                    invalidEnemyLocs.Add(new Point(P.X + 1, P.Y + 1));
                    invalidEnemyLocs.Add(new Point(P.X, P.Y - 2));
                    invalidEnemyLocs.Add(new Point(P.X, P.Y - 1));
                    invalidEnemyLocs.Add(new Point(P.X, P.Y + 2));
                    invalidEnemyLocs.Add(new Point(P.X, P.Y + 1));
                    invalidEnemyLocs.Add(new Point(P.X - 2, P.Y));
                    invalidEnemyLocs.Add(new Point(P.X - 1, P.Y));
                    invalidEnemyLocs.Add(new Point(P.X + 2, P.Y));
                    invalidEnemyLocs.Add(new Point(P.X + 1, P.Y));
                }
                else
                {
                    i--;
                }
            }

        }

        public void playerMove(char? direction)
        {
            switch (direction)
            {
                case 'W':
                    if (activeMap.canEnter(playerX, (playerY - 1)))
                    {
                        playerY--;
                        if (activeMap.returnTeleport(playerX, playerY))
                        {
                            teleport();
                        }
                        else
                        {
                            Form1.UpdateForm.NewFormEvent(1, null);
                        }
                    }
                    break;
                case 'A':
                    if (activeMap.canEnter((playerX - 1), playerY))
                    {
                        playerX--;
                        if (activeMap.returnTeleport(playerX, playerY))
                        {
                            teleport();
                        }
                        else
                        {
                            Form1.UpdateForm.NewFormEvent(1, null);
                        }
                    }
                    break;
                case 'S':
                    if (activeMap.canEnter(playerX, (playerY + 1)))
                    {
                        playerY++;
                        if (activeMap.returnTeleport(playerX, playerY))
                        {
                            teleport();
                        }
                        else
                        {
                            Form1.UpdateForm.NewFormEvent(1, null);
                        }
                    }
                    break;
                case 'D':
                    if (activeMap.canEnter((playerX + 1), playerY))
                    {
                        playerX++;
                        if (activeMap.returnTeleport(playerX, playerY))
                        {
                            teleport();
                        }
                        else
                        {
                            Form1.UpdateForm.NewFormEvent(1, null);
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void teleport()
        {
            mapString = activeMap.returnMapString(playerX, playerY);
            playerX = Convert.ToInt32(mapString.Substring(3, 3));
            playerY = Convert.ToInt32(mapString.Substring(6, 3));
            mapName = mapString.Substring(9);
            Form1.UpdateForm.NewFormEvent(2, "You have now entered " + mapName);
            loadMap(mapName);
        }
    }
}
