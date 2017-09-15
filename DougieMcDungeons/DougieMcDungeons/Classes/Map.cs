using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DougieMcDungeons.Classes
{
    public class Map
    {
        public int xLength = 0;
        public int yLength = 0;
        public string mapsName = null;
        private int minNumEnemies = 0;
        private int maxNumEnemies = 0;
        public List<string[]> mapImageNums = new List<string[]>();
        private List<string> enemyTypes = new List<string>();
        public List<Point> mapEnemyLocs = new List<Point>();
        public List<Enemy> enemiesOnMap = new List<Enemy>();
        private Random rand = new Random();

        public Map(string mapName)
        {
            mapsName = mapName;
            int i = 0;//Our tracking index to keep track of where we are in the map file 

            string[] mapFile = null;
            if (mapName == "firstmap")
            {
                mapFile = Properties.Resources.firstMap1.Split('\n');
            }
            else if (mapName == "secondmap")
            {
                mapFile = Properties.Resources.secondMap1.Split('\n');
            }
            else if (mapName == "Spooky Ghosts Lair")
            {
                mapFile = Properties.Resources.spookyghost.Split('\n');
            }

            for (int x = 0; x < mapFile.Length; x++)
            {
                string[] newstring = mapFile[x].Split(',');
                mapImageNums.Add(newstring);
                xLength = newstring.Length - 1;
            }
            yLength = mapFile.Length - 1;

            minNumEnemies = Convert.ToInt32(mapImageNums[i][0].Substring(3));
            i++;
            maxNumEnemies = Convert.ToInt32(mapImageNums[i][0].Substring(3));
            i++;
            //2 was originally intended to be an enemy min level
            i++;
            //3 was originally intended to be an enemy max level
            i++;
            for (i = 4; i > 0; i++)//Reassign i but we will always be at 4 here
            {
                if (mapImageNums[i][0].Substring(3) != "end")
                {
                    enemyTypes.Add(mapImageNums[i][0].Substring(3));
                }
                else
                {
                    break;
                }
            }

            int numEnemies = rand.Next(minNumEnemies, maxNumEnemies + 1);

            for (int j = 0; j < numEnemies; j++)
            {
                switch (enemyTypes[rand.Next(0, (enemyTypes.Count))])
                {
                    case "gnome":
                        enemiesOnMap.Add(new Gnome("gnome"));
                        break;
                    case "ooze":
                        enemiesOnMap.Add(new Ooze("ooze"));
                        break;
                    case "elephant":
                        enemiesOnMap.Add(new Elephant("elephant"));
                        break;
                    case "pumpkin":
                        enemiesOnMap.Add(new Pumpkin("pumpkin"));
                        break;
                    case "ghost":
                        enemiesOnMap.Add(new Ghost("ghost"));
                        break;
                }
            }

            if(minNumEnemies == maxNumEnemies)//When we define an exact number of enemies we will define their locs too
            {
                i++;
                while(i > 0)
                {
                    if (mapImageNums[i][0].Substring(3) != "end")
                    {
                        mapEnemyLocs.Add(new Point(Convert.ToInt32(mapImageNums[i][0].Substring(3)), Convert.ToInt32(mapImageNums[i + 1][0].Substring(3))));
                        i++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
            }


        }

        public Image returnImage(int x, int y)
        {
            if (mapImageNums[y][x].Substring(0, 3) == "000")
            {
                return Properties.Resources.black1;
            }
            else if (mapImageNums[y][x].Substring(0, 3) == "001")
            {
                return Properties.Resources.grass1;
            }
            else if (mapImageNums[y][x].Substring(0, 3) == "002")
            {
                return Properties.Resources.grass2;
            }
            else if (mapImageNums[y][x].Substring(0, 3) == "003")
            {
                return Properties.Resources.grass3;
            }
            else if (mapImageNums[y][x].Substring(0, 3) == "004")
            {
                return Properties.Resources.dirtpath1;
            }
            else if (mapImageNums[y][x].Substring(0, 3) == "005")
            {
                return Properties.Resources.water1;
            }
            else if (mapImageNums[y][x].Substring(0, 3) == "006")
            {
                return Properties.Resources.water2;
            }
            else if (mapImageNums[y][x].Substring(0, 3) == "007")
            {
                return Properties.Resources.bridge1;
            }
            else if (mapImageNums[y][x].Substring(0, 3) == "998")
            {
                return Properties.Resources.teleport1;
            }
            else if (mapImageNums[y][x].Substring(0, 3) == "999")
            {
                return Properties.Resources.steve1;
            }
            return Properties.Resources.black1;
        }

        public bool canEnter(int x, int y)
        {
            if (mapImageNums[y][x].Substring(0, 3) != "000" && mapImageNums[y][x].Substring(0, 3) != "005" && mapImageNums[y][x].Substring(0, 3) != "006")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool returnTeleport(int x, int y)
        {
            if (mapImageNums[y][x].Substring(0, 3) == "998")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string returnMapString(int x, int y)
        {
            return mapImageNums[y][x];
        }
    }
}
