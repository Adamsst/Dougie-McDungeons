using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DougieMcDungeons.Classes
{
    public class Skill
    {

        protected string _name = "None";
        protected int _Cooldown;
        public Image img;
        protected Random rand;
        public int maxCooldown;//Actual Cooldown will be 1 less than max because a skill cools down by 1 on use
        protected Player skillPlayer;

        public Skill(Player p)
        {
            skillPlayer = p;
        }

        public virtual int attack(Enemy e)
        {
            return 0;
        }

        public int cooldown
        {
            get { return _Cooldown; }
            set { _Cooldown = Math.Max(0, value); }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    public class ExhaustedSwing : Skill
    {
        public ExhaustedSwing(Player p) : base(p)
        {
            _name = "Exhausted Strike";
            _Cooldown = 0;
            img = Properties.Resources.exhaustedstrike;
            maxCooldown = 0;
            skillPlayer = p;
        }

        public override int attack(Enemy e)
        {
            cooldown = maxCooldown;
            int totalDamage = 0;
            int reducDamage = 0;
            rand = new Random();
            if ((rand.Next(0, 100) > (skillPlayer.totalStats["atkhit"] / 2)))
            {
                Form1.UpdateForm.NewFormEvent(1, "Exhausted Swing misses.");
                return 0;
            }
            else
            {
                for (int i = 0; i < e.def; i++)
                {
                    if (rand.Next(0, 10) == 0)
                    {
                        reducDamage++;
                    }
                }
                totalDamage = skillPlayer.totalStats["atk"];
                Form1.UpdateForm.NewFormEvent(1, "Exhausted Swing hits for " + Math.Max(0, (totalDamage - reducDamage)) + " damage.");
                return Math.Max(0, (totalDamage - reducDamage));
            }
        }

    }

    public class SimpleStrike : Skill
    {
        public SimpleStrike(Player p) : base(p)
        {
            _name = "Simple Strike";
            cooldown = 0;
            img = Properties.Resources.simplestrike;
            maxCooldown = 6;
            skillPlayer = p;
        }

        public override int attack(Enemy e)
        {
            cooldown = maxCooldown;
            int totalDamage = 0;
            int reducDamage = 0;
            rand = new Random();
            if((rand.Next(0,100) > skillPlayer.totalStats["atkhit"]))
            {
                Form1.UpdateForm.NewFormEvent(1, "Simple Strike misses.");
                return 0;
            }
            else
            {
                for (int i = 0; i < e.def; i++)
                {
                    if (rand.Next(0, 10) == 0)
                    {
                        reducDamage++;
                    }
                }
                if (rand.Next(0, 100) < skillPlayer.totalStats["atkcrit"])
                {
                    totalDamage = skillPlayer.totalStats["atk"] * 2;
                    Form1.UpdateForm.NewFormEvent(1, "Simple Strike critically hits for " + Math.Max(0, (totalDamage - reducDamage)) + " damage.");
                }
                else
                {
                    totalDamage = skillPlayer.totalStats["atk"];
                    Form1.UpdateForm.NewFormEvent(1, "Simple Strike hits for " + Math.Max(0, (totalDamage - reducDamage)) + " damage.");
                }
                return Math.Max(0, (totalDamage - reducDamage));
            }
        }

    }

    public class SorcerersGambit : Skill
    {
        public SorcerersGambit(Player p) : base(p)
        {
            _name = "Sorcerers Gambit";
            _Cooldown = 0;
            img = Properties.Resources.sorcerersgambit;
            maxCooldown = 4;
            skillPlayer = p;
        }

        public override int attack(Enemy e)
        {
            cooldown = maxCooldown;
            int totalDamage = 0;
            int reducDamage = 0;
            rand = new Random();
            if ((rand.Next(0, 100) > skillPlayer.totalStats["matkhit"]))
            {
                Form1.UpdateForm.NewFormEvent(1, "Sorcerers gambit fails.");
                return 0;
            }
            else
            {
                for (int i = 0; i < e.mdef; i++)
                {
                    if (rand.Next(0, 10) == 0)
                    {
                        reducDamage++;
                    }
                }

                if (rand.Next(0, 100) < skillPlayer.totalStats["matkcrit"])
                {
                    totalDamage = rand.Next(0, (skillPlayer.totalStats["matk"] * 3)) * 2;
                    Form1.UpdateForm.NewFormEvent(1, "Sorcerers Gambit connects for " + Math.Max(0, (totalDamage - reducDamage)) + " damage.");
                }
                else
                {
                    totalDamage = rand.Next(0, (skillPlayer.totalStats["matk"] * 3));
                    Form1.UpdateForm.NewFormEvent(1, "Sorcerers Gambit connects for " + Math.Max(0, (totalDamage - reducDamage)) + " damage.");
                }

                return Math.Max(0, (totalDamage - reducDamage));
            }
        }
    }
}
