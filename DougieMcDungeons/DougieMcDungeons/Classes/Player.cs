using System;
using System.Collections.Generic;

namespace DougieMcDungeons.Classes
{
    public class Player
    {
        public Dictionary<string, int> baseStats = new Dictionary<string, int>();
        public Dictionary<string, int> bonusStats = new Dictionary<string, int>();
        public Dictionary<string, int> totalStats = new Dictionary<string, int>();
        private string[] statDescrips = new string[] { "maxhp", "def", "mdef", "atk", "matk", "atkcrit", "matkcrit", "atkhit", "matkhit" };//HP excluded since environment affected
        public Skill[] skillSet = new Skill[10];
        public List<Equipment> equipmentInventory = new List<Equipment>();
        public List<Essence> essenceInventory = new List<Essence>();
        public List<Skill> skillInventory = new List<Skill>();
        public Equipment head = null;
        public Equipment chest = null;
        public Equipment legs = null;
        public Equipment feet = null;
        public Equipment hands = null;
        public Equipment weapon = null;
        public int gold = 0;
        public int exp = 0;
        public int level = 0;
        public int[] expNeeded = new int[10] { 10, 20, 30, 45, 60, 80, 100, 125, 150, 200 };

        Random playerR = new Random();
        public string one = "Simple Strike";
        public string zero = "Exhausted Swing";

        public Player()
        {
            baseStats.Add("hp", 0);
            baseStats.Add("maxhp", 25);
            baseStats.Add("def", 1);
            baseStats.Add("mdef", 1);
            baseStats.Add("atk", 3);
            baseStats.Add("matk", 1);
            baseStats.Add("atkcrit", 1);
            baseStats.Add("matkcrit", 1);
            baseStats.Add("atkhit", 70);
            baseStats.Add("matkhit", 50);

            bonusStats.Add("hp", 0);
            bonusStats.Add("maxhp", 0);
            bonusStats.Add("def", 0);
            bonusStats.Add("mdef", 0);
            bonusStats.Add("atk", 0);
            bonusStats.Add("matk", 0);
            bonusStats.Add("atkcrit", 0);
            bonusStats.Add("matkcrit", 0);
            bonusStats.Add("atkhit", 0);
            bonusStats.Add("matkhit", 0);

            totalStats.Add("hp", 25);
            totalStats.Add("maxhp", 0);
            totalStats.Add("def", 0);
            totalStats.Add("mdef", 0);
            totalStats.Add("atk", 0);
            totalStats.Add("matk", 0);
            totalStats.Add("atkcrit", 0);
            totalStats.Add("matkcrit", 0);
            totalStats.Add("atkhit", 0);
            totalStats.Add("matkhit", 0);

            calculateTotalStats();
            skillSet[0] = new ExhaustedSwing(this);
            skillSet[1] = new Skill(this);
            skillSet[2] = new Skill(this);
            skillSet[3] = new Skill(this);
            skillSet[4] = new Skill(this);
            skillSet[5] = new Skill(this);
            skillSet[6] = new Skill(this);
            skillSet[7] = new Skill(this);
            skillSet[8] = new Skill(this);
            skillSet[9] = new Skill(this);
            skillInventory.Add(new Skill(this));
            skillInventory.Add(new SorcerersGambit(this));
            skillInventory.Add(new SimpleStrike(this));
        }

        private void calculateTotalStats()
        {
            foreach (string s in statDescrips)
            {
                totalStats[s] = baseStats[s] + bonusStats[s];
            }
        }

        public void addModsValue()
        {
            foreach (string s in statDescrips)
            {
                bonusStats[s] = 0;
            }

            if (head != null)
            {
                for (int i = 0; i < head.mods.Count; i++)
                {
                    bonusStats[head.mods[i].statistic] += head.mods[i].magnitude;
                }
                if (head.ess != null)
                {
                    for (int i = 0; i < head.ess.mods.Count; i++)
                    {
                        bonusStats[head.ess.mods[i].statistic] += head.ess.mods[i].magnitude;
                    }
                }
            }
            if (chest != null)
            {
                for (int i = 0; i < chest.mods.Count; i++)
                {
                    bonusStats[chest.mods[i].statistic] += chest.mods[i].magnitude;
                }
                if (chest.ess != null)
                {
                    for (int i = 0; i < chest.ess.mods.Count; i++)
                    {
                        bonusStats[chest.ess.mods[i].statistic] += chest.ess.mods[i].magnitude;
                    }
                }
            }
            if (legs != null)
            {
                for (int i = 0; i < legs.mods.Count; i++)
                {
                    bonusStats[legs.mods[i].statistic] += legs.mods[i].magnitude;
                }
                if (legs.ess != null)
                {
                    for (int i = 0; i < legs.ess.mods.Count; i++)
                    {
                        bonusStats[legs.ess.mods[i].statistic] += legs.ess.mods[i].magnitude;
                    }
                }
            }
            if (hands != null)
            {
                for (int i = 0; i < hands.mods.Count; i++)
                {
                    bonusStats[hands.mods[i].statistic] += hands.mods[i].magnitude;
                }
                if (hands.ess != null)
                {
                    for (int i = 0; i < hands.ess.mods.Count; i++)
                    {
                        bonusStats[hands.ess.mods[i].statistic] += hands.ess.mods[i].magnitude;
                    }
                }
            }
            if (feet != null)
            {
                for (int i = 0; i < feet.mods.Count; i++)
                {
                    bonusStats[feet.mods[i].statistic] += feet.mods[i].magnitude;
                }
                if (feet.ess != null)
                {
                    for (int i = 0; i < feet.ess.mods.Count; i++)
                    {
                        bonusStats[feet.ess.mods[i].statistic] += feet.ess.mods[i].magnitude;
                    }
                }
            }
            if (weapon != null)
            {
                for (int i = 0; i < weapon.mods.Count; i++)
                {
                    bonusStats[weapon.mods[i].statistic] += weapon.mods[i].magnitude;
                }
                if (weapon.ess != null)
                {
                    for (int i = 0; i < weapon.ess.mods.Count; i++)
                    {
                        bonusStats[weapon.ess.mods[i].statistic] += weapon.ess.mods[i].magnitude;
                    }
                }
            }
            calculateTotalStats();
        }

        public void levelUp(int xp)
        {
            exp += xp;
            if(exp >= expNeeded[level] && level < expNeeded.Length - 1)
            {
                level++;
                exp = 0;
                levelUpStats(level);
                totalStats["hp"] = baseStats["maxhp"];
                addModsValue();
                Form1.UpdateForm.NewFormEvent(1, "You have levelled up!");
                Form1.UpdateForm.NewFormEvent(6, "No message");
            }
        }

        private void levelUpStats(int lvl)
        {
            switch (lvl)
            {
                case 1:
                case 2:
                case 4:
                case 5:
                case 7:
                case 8:
                    baseStats["atkcrit"] += 1;
                    baseStats["matkcrit"] += 1;
                    baseStats["atkhit"] += 1;
                    baseStats["matkhit"] += 1;
                    baseStats["maxhp"] += 5;
                    break;
                case 3:
                case 6:
                case 9:
                    baseStats["def"] += 1;
                    baseStats["mdef"] += 1;
                    baseStats["atk"] += 1;
                    baseStats["matk"] += 1;
                    break;
                default:
                    break;
            }
        }
    }


}
