using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DougieMcDungeons.Classes
{
    class Map
    {
        private int xLength = 0;
        private int yLength = 0;
        private int minNumEnemies = 0;
        private int maxNumEnemies = 0;
        private List<string[]> mapImageNums = new List<string[]>();
        private List<string> enemyTypes = new List<string>();
        private List<Enemy> enemiesOnMap = new List<Enemy>();
        private Random rand = new Random();

        public Map(string mapName)
        {
            string[] mapFile = null;
            if (mapName == "firstmap")
            {
                mapFile = Properties.Resources.firstMap1.Split('\n');
            }
            else if (mapName == "secondmap")
            {
                mapFile = Properties.Resources.secondMap1.Split('\n');
            }

            for (int x = 0; x < mapFile.Length; x++)
            {
                string[] newstring = mapFile[x].Split(',');
                mapImageNums.Add(newstring);
                xLength = newstring.Length - 1;
            }
            yLength = mapFile.Length - 1;

            minNumEnemies = Convert.ToInt32(mapImageNums[0][0].Substring(3));
            maxNumEnemies = Convert.ToInt32(mapImageNums[1][0].Substring(3));

            for (int i = 4; i > 0; i++)
            {
                if (mapImageNums[i][0].Substring(3) != "end")
                {
                    enemyTypes.Add(mapImageNums[i][0].Substring(3));
                }
                else
                {
                    i = -1;
                }
            }

            int numEnemies = rand.Next(minNumEnemies, maxNumEnemies + 1);

            for (int i = 0; i < numEnemies; i++)
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
