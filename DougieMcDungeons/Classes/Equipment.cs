using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DougieMcDungeons.Classes
{
    public class Equipment : IEquatable<Equipment>
    {
        public string name;
        public Essence ess;
        public int slots;
        public string location;
        public List<Stats> mods = new List<Stats>();
        public Equipment(string n)
        {
            name = n;
            string equipmentText = Properties.Resources.equipment;
            ess = null;
            using (var reader = new StringReader(equipmentText))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    if (values[0] == name)
                    {
                        location = values[3];
                        slots = Convert.ToInt32(values[4]);
                        for (int i = 5; i < values.Length; i++)
                        {
                            mods.Add(new Stats(values[i], Convert.ToInt32(values[i + 1])));
                            i++;
                        }
                        break;
                    }
                }
            }
        }

        public bool Equals(Equipment other)//This is so equipment remains equipped if there are multiple instances in the inventory and one is deleted
        {
            return (this.name == other.name);
        }
    }
}
