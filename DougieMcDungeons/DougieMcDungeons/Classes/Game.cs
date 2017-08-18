using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace DougieMcDungeons.Classes
{
    public class Game : INotifyPropertyChanged
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
        public bool inBattle = false;
        private int target = 0;

        public event PropertyChangedEventHandler PropertyChanged;

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
            player.essenceInventory.Add(new Essence("Essence of Gnome"));
            player.essenceInventory.Add(new Essence("Essence of Gnome"));
            player.essenceInventory.Add(new Essence("Essence of Gnome"));
            player.essenceInventory.Add(new Essence("Essence of Gnome"));
            player.essenceInventory.Add(new Essence("Essence of Gnome"));
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
            if (!inBattle)
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
                                coordinates = ("Coordinates: " + (playerX - 8).ToString() + ", " + (playerY - 8).ToString());
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
                                coordinates = ("Coordinates: " + (playerX - 8).ToString() + ", " + (playerY - 8).ToString());
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
                                coordinates = ("Coordinates: " + (playerX - 8).ToString() + ", " + (playerY - 8).ToString());
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
                                coordinates = ("Coordinates: " + (playerX - 8).ToString() + ", " + (playerY - 8).ToString());
                            }
                        }
                        break;
                    default:
                        break;
                }
                for (int i = 0; i < enemyLocs.Count; i++)
                {
                    if (enemyLocs[i] == new Point(playerX - 9, playerY - 8) || enemyLocs[i] == new Point(playerX - 7, playerY - 8) || enemyLocs[i] == new Point(playerX - 8, playerY - 9) || enemyLocs[i] == new Point(playerX - 8, playerY - 7))
                    {
                        target = i;
                        Form1.UpdateForm.NewFormEvent(1, "You've entered battle with " + activeMap.enemiesOnMap[target].type + "!");
                        inBattle = true;
                    }
                }
            }
        }

        private void teleport()
        {
            mapString = activeMap.returnMapString(playerX, playerY);
            playerX = Convert.ToInt32(mapString.Substring(3, 3));
            playerY = Convert.ToInt32(mapString.Substring(6, 3));
            mapName = mapString.Substring(9);
            coordinates = ("Coordinates: " + playerX.ToString() + ", " + playerY.ToString());
            Form1.UpdateForm.NewFormEvent(2, "You have now entered " + mapName);
            loadMap(mapName);
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string coordinates
        {
            get { return ("Coordinates: " + (playerX - 8).ToString() + ", " + (playerY - 8).ToString()); }
            set
            {
                NotifyPropertyChanged("coordinates");
            }
        }

        public void battleTurn(int playerAtk)
        {
            if (player.skillSet[playerAtk].name != "None")
            {
                activeMap.enemiesOnMap[target].hp -= player.skillSet[playerAtk].attack(activeMap.enemiesOnMap[target]);
                if (activeMap.enemiesOnMap[target].hp <= 0)
                {
                    Form1.UpdateForm.NewFormEvent(1, "You have defeated the " + activeMap.enemiesOnMap[target].type);
                    activeMap.enemiesOnMap.RemoveAt(target);
                    enemyLocs.RemoveAt(target);
                    inBattle = false;
                }
            }
        }
    }
}
