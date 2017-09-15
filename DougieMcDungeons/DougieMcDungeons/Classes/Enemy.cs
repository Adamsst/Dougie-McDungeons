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

        public virtual int attack(Player p)
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
        public override int attack(Player p)
        {
            Form1.UpdateForm.NewFormEvent(1, "Gnome sabotages you for 4 damage.");
            return 4;
        }
    }
    class Ooze : Enemy
    {
        public Ooze(string name) : base(name)
        {
            img = Properties.Resources.ooze;
        }
        public override int attack(Player p)
        {
            int totalDamage = 3;
            int reducDamage = 0;
            r = new Random();

            for (int i = 0; i < p.totalStats["mdef"]; i++)
            {
                if (r.Next(0, 10) <= 1)//double the mdef chance
                {
                    reducDamage++;
                }
            }

            Form1.UpdateForm.NewFormEvent(1, "Ooze stings for " + (totalDamage - reducDamage) + " damage.");
            return (totalDamage - reducDamage);
        }
        public override string lootRoll()
        {
            r = new Random();
            int lootNum = r.Next(0, 100);//0-99
            Console.WriteLine(lootNum);
            if (lootNum == 0)
            {
                return "Essence of Ooze";
            }
            else if (lootNum >= 1 && lootNum <= 5)
            {
                return "Ripped Gloves";
            }
            else if (lootNum >= 6 && lootNum <= 10)
            {
                return "Plain Shirt";
            }
            else if (lootNum >= 11 && lootNum <= 15)
            {
                return "Tattered Shoes";
            }
            else if (lootNum >= 16 && lootNum <= 17)
            {
                return "Novice Staff";
            }
            else if (lootNum == 18)
            {
                return "Casters Robe";
            }
            else
            {
                return "0";
            }
        }
    }
    class Elephant : Enemy
    {
        public Elephant(string name) : base(name)
        {
            img = Properties.Resources.elephant;
        }
        public override int attack(Player p)
        {
            Form1.UpdateForm.NewFormEvent(1, "Elephant stomps you for 3 damage.");
            return 3;
        }
    }
    class Pumpkin : Enemy
    {
        public Pumpkin(string name) : base(name)
        {
            img = Properties.Resources.pumpkin;
        }
        public override int attack(Player p)
        {
            Form1.UpdateForm.NewFormEvent(1, "Pumpkin attacks for 1 damage.");
            return 1;
        }
        public override string lootRoll()
        {
            r = new Random();
            int lootNum = r.Next(0, 100);//0-99
            Console.WriteLine(lootNum);
            if (lootNum == 0)
            {
                return "Essence of Pumpkin";
            }
            else if (lootNum >= 1 && lootNum <= 5)
            {
                return "Basic Helm";
            }
            else if (lootNum >= 6 && lootNum <= 7)
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

    class Ghost : Enemy
    {
        public Ghost(string name) : base(name)
        {
            img = Properties.Resources.ghost;
        }
        public override int attack(Player p)
        {
            Form1.UpdateForm.NewFormEvent(1, "Ghost spooked you for " + "0" + " damage.");
            return 0;
        }
        public override string lootRoll()
        {
            return "0";
        }
    }
}
