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
        public int playerY = 9;
        string mapString = null;//Used to hold data to be parsed when a new map is loaded
        public Point[,] map = new Point[17, 17];
        string mapName = "town";
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
            //player.equipmentInventory.Add(new Equipment("Basic Helm[1]"));
            //player.equipmentInventory.Add(new Equipment("Tattered Shoes"));
            //player.essenceInventory.Add(new Essence("Essence of Pumpkin"));
            //-player.essenceInventory.Add(new Essence("Essence of Ooze"));
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
            if (activeMap.mapEnemyLocs.Count == 0)
            {
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
            else
            {
                foreach(Point mel in activeMap.mapEnemyLocs)
                {
                    enemyLocs.Add(mel);
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

        internal string[] openVendor()
        {
           if(activeMap.mapVendorLocs.Contains(new Point(playerX - 7, playerY - 8)))
           {
               return new string[2] { activeMap.vendorsOnMap[activeMap.mapVendorLocs.IndexOf(new Point(playerX - 7, playerY - 8))].name, activeMap.vendorsOnMap[activeMap.mapVendorLocs.IndexOf(new Point(playerX - 7, playerY - 8))].vendorType };
           }
           else if (activeMap.mapVendorLocs.Contains(new Point(playerX - 9, playerY - 8)))
           {
                return new string[2] { activeMap.vendorsOnMap[activeMap.mapVendorLocs.IndexOf(new Point(playerX - 9, playerY - 8))].name, activeMap.vendorsOnMap[activeMap.mapVendorLocs.IndexOf(new Point(playerX - 9, playerY - 8))].vendorType };
            }
           else if (activeMap.mapVendorLocs.Contains(new Point(playerX - 8, playerY - 7)))
           {
                return new string[2] { activeMap.vendorsOnMap[activeMap.mapVendorLocs.IndexOf(new Point(playerX - 8, playerY - 7))].name, activeMap.vendorsOnMap[activeMap.mapVendorLocs.IndexOf(new Point(playerX - 8, playerY - 7))].vendorType };
            }
           else if (activeMap.mapVendorLocs.Contains(new Point(playerX - 8, playerY - 9)))
           {
                return new string[2] { activeMap.vendorsOnMap[activeMap.mapVendorLocs.IndexOf(new Point(playerX - 8, playerY - 9))].name, activeMap.vendorsOnMap[activeMap.mapVendorLocs.IndexOf(new Point(playerX - 8, playerY - 9))].vendorType };
            }
            else
           {
               return new string[2] { "none", "none" };
           }
        }

        private void teleport()
        {
            player.totalStats["hp"] = player.totalStats["maxhp"];//Temporary heal hack on map change
            mapString = activeMap.returnMapString(playerX, playerY);
            playerX = Convert.ToInt32(mapString.Substring(3, 3));
            playerY = Convert.ToInt32(mapString.Substring(6, 3));
            mapName = mapString.Substring(9);
            coordinates = ("Coordinates: " + playerX.ToString() + ", " + playerY.ToString());
            loadMap(mapName);
            Form1.UpdateForm.NewFormEvent(2, "You have now entered " + mapName);
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
                if (player.skillSet[playerAtk].cooldown == 0)
                {
                    activeMap.enemiesOnMap[target].hp -= player.skillSet[playerAtk].attack(activeMap.enemiesOnMap[target]);

                    foreach(Skill ski in player.skillSet)
                    {
                        ski.cooldown--;
                    }

                    if (activeMap.enemiesOnMap[target].hp <= 0)
                    {
                        Form1.UpdateForm.NewFormEvent(1, "You have defeated the " + activeMap.enemiesOnMap[target].type + ".");
                        player.levelUp(activeMap.enemiesOnMap[target].exp);

                        string loot = activeMap.enemiesOnMap[target].lootRoll();
                        if (loot != "0")
                        {
                            if (loot.Equals("Gold"))
                            {
                                int tempGoldHold = activeMap.enemiesOnMap[target].goldRoll();
                                player.gold += tempGoldHold;
                                Form1.UpdateForm.NewFormEvent(1, "You have found " + tempGoldHold + " Gold!");
                            }
                            else
                            {
                                Form1.UpdateForm.NewFormEvent(1, "You have found " + loot + "!");
                                if (loot.Substring(0, 7).Equals("Essence"))
                                {
                                    player.essenceInventory.Add(new Essence(loot));
                                }
                                else
                                {
                                    player.equipmentInventory.Add(new Equipment(loot));
                                }
                            }
                        }
                        Form1.UpdateForm.NewFormEvent(6, "No message");
                        activeMap.enemiesOnMap.RemoveAt(target);
                        enemyLocs.RemoveAt(target);
                        inBattle = false;
                    }
                    else
                    {
                        player.totalStats["hp"] -= activeMap.enemiesOnMap[target].attack(player);
                        Form1.UpdateForm.NewFormEvent(6, "No message");
                        if (player.totalStats["hp"] <= 0)
                        {
                            Form1.UpdateForm.NewFormEvent(7, "You have died a tragic death");
                        }
                    }
                }//End check to make sure skill is off cooldown, else no action taken
            }//End Check for skill name of "None" aka no action taken
        }
    }
}
