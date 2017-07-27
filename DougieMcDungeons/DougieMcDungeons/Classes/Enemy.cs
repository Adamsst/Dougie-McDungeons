using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DougieMcDungeons.Classes
{
    public class Enemy
    {

        public int hp = 0;
        public int maxhp = 0;
        public int def = 0;
        public int mdef = 0;
        public int atk = 0;
        public int matk = 0;
        public int atkcrit = 0;
        public int matkcrit = 0;
        public int atkhit = 0;
        public int matkhit = 0;
        public string type = null;
        public Image img;
        protected Random r;

        public Enemy(string name)
        {
            string enemyText = Properties.Resources.enemies;
            type = name;

            using (var reader = new StringReader(enemyText))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    if (values[0] == name)
                    {
                        hp = Convert.ToInt32(values[1]);
                        maxhp = Convert.ToInt32(values[2]);
                        def = Convert.ToInt32(values[3]);
                        mdef = Convert.ToInt32(values[4]);
                        atk = Convert.ToInt32(values[5]);
                        matk = Convert.ToInt32(values[6]);
                        atkcrit = Convert.ToInt32(values[7]);
                        matkcrit = Convert.ToInt32(values[8]);
                        atkhit = Convert.ToInt32(values[9]);
                        matkhit = Convert.ToInt32(values[10]);
                    }
                }
            }
        }

        public virtual int attack()
        {
            return 0;
        }

        public virtual string lootRoll()
        {
            return "0";
        }

    }

    class Gnome : Enemy
    {
        public Gnome(string name) : base(name)
        {
            img = Properties.Resources.gnome;
        }
        public override int attack()
        {
            return 4;
        }
    }
    class Ooze : Enemy
    {
        public Ooze(string name) : base(name)
        {
            img = Properties.Resources.ooze;
        }
        public override int attack()
        {
            return 2;
        }
    }
    class Elephant : Enemy
    {
        public Elephant(string name) : base(name)
        {
            img = Properties.Resources.elephant;
        }
        public override int attack()
        {
            return 3;
        }
    }
    class Pumpkin : Enemy
    {
        public Pumpkin(string name) : base(name)
        {
            img = Properties.Resources.pumpkin;
        }
        public override int attack()
        {
            return 1;
        }
        public override string lootRoll()
        {
            r = new Random();
            int lootNum = r.Next(0, 100);
            Console.WriteLine(lootNum);
            if (lootNum >= 0 && lootNum <= 2)
            {
                return "Essence of Pumpkin";
            }
            else if (lootNum >= 3 && lootNum <= 6)
            {
                return "Basic Helm";
            }
            else if (lootNum == 7)
            {
                return "Short Sword";
            }
            else if (lootNum >= 8 && lootNum <= 9)
            {
                return "Basic Helm[1]";
            }
            else if (lootNum >= 10 && lootNum <= 16)
            {
                return "Denim Shorts[1]";
            }
            else
            {
                return "0";
            }
        }
    }
}
