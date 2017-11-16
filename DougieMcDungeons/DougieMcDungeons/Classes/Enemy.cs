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
        public int exp = 0;
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
                        exp = Convert.ToInt32(values[11]);
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

        public virtual int goldRoll()
        {
            return (r.Next(0,(2*exp)) + 1);
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
            int totalDamage = 4;
            int reducDamage = 0;
            r = new Random();
            for (int i = 0; i < p.totalStats["def"]; i++)
            {
                if (r.Next(0, 9) <= 1)//double the def chance
                {
                    reducDamage++;
                }
            }
            if (r.Next(0, 9) == 0)//10% crit on gnomies
            {
                totalDamage += 4;
                Form1.UpdateForm.NewFormEvent(1, "Gnome critically stabs you for " + Math.Max(0, (totalDamage - reducDamage)) + " damage.");
            }
            else
            {
                Form1.UpdateForm.NewFormEvent(1, "Gnome stabs you for " + Math.Max(0, (totalDamage - reducDamage)) + " damage.");
            }
            return Math.Max(0, (totalDamage - reducDamage));
        }
        public override string lootRoll()
        {
            r = new Random();
            int lootNum = r.Next(0, 100);//0-99
            Console.WriteLine(lootNum);
            if (lootNum == 0)
            {
                return "Essence of Gnome";
            }
            else if (lootNum >= 1 && lootNum <= 10)
            {
                return "Gold";
            }
            else if (lootNum == 11)
            {
                return "Defenders Axe";
            }
            else if (lootNum == 12)
            {
                return "Tattered Shoes[1]";
            }
            else
            {
                return "0";
            }
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
            int totalDamage = 2;
            int reducDamage = 0;
            r = new Random();

            for (int i = 0; i < p.totalStats["mdef"]; i++)
            {
                if (r.Next(0, 9) <= 1)//double the mdef chance
                {
                    reducDamage++;
                }
            }

            Form1.UpdateForm.NewFormEvent(1, "Ooze stings for " + Math.Max(0,(totalDamage - reducDamage)) + " damage.");
            return Math.Max(0, (totalDamage - reducDamage));
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
            else if (lootNum >= 19 && lootNum <= 20)
            {
                return "Gold";
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
            int totalDamage = 3;
            int reducDamage = 0;
            r = new Random();

            for (int i = 0; i < p.totalStats["def"]; i++)
            {
                if (r.Next(0, 9) == 0)
                {
                    reducDamage++;
                }
            }

            Form1.UpdateForm.NewFormEvent(1, "Elephant stomps you for " + Math.Max(0, (totalDamage - reducDamage)) + " damage.");
            return Math.Max(0, (totalDamage - reducDamage));
        }
        public override string lootRoll()
        {
            r = new Random();
            int lootNum = r.Next(0, 100);//0-99
            Console.WriteLine(lootNum);
            if (lootNum == 0)
            {
                return "Essence of Elephant";
            }
            else if (lootNum >= 1 && lootNum <= 10)
            {
                return "Gold";
            }
            else if (lootNum == 11)
            {
                return "Short Sword[1]";
            }
            else if (lootNum >= 12 && lootNum <= 13)
            {
                return "Casters Robe";
            }
            else if (lootNum == 14)
            {
                return "Ripped Gloves[1]";
            }
            else
            {
                return "0";
            }
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
            else if (lootNum >= 17 && lootNum <= 20)
            {
                return "Gold";
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
            int totalDamage = 3;
            int reducDamage = 0;
            r = new Random();

            for (int i = 0; i < p.totalStats["def"]; i++)
            {
                if (r.Next(0, 9) == 0)
                {
                    reducDamage++;
                }
            }
            for (int i = 0; i < p.totalStats["mdef"]; i++)
            {
                if (r.Next(0, 9) == 0)
                {
                    reducDamage++;
                }
            }

            Form1.UpdateForm.NewFormEvent(1, "Ghost spooked you for " + Math.Max(0, (totalDamage - reducDamage)) + " damage.");
            return Math.Max(0, (totalDamage - reducDamage));
        }
        public override string lootRoll()
        {
            r = new Random();
            int lootNum = r.Next(0, 100);//0-99
            Console.WriteLine(lootNum);
            if (lootNum == 0)
            {
                return "Essence of Ghost";
            }
            else if (lootNum >= 1 && lootNum <= 10)
            {
                return "Gold";
            }
            else if (lootNum == 11)
            {
                return "Unruly Wand[1]";
            }
            else if (lootNum == 12)
            {
                return "Casters Robe[1]";
            }
            else
            {
                return "0";
            }
        }
    }
}
