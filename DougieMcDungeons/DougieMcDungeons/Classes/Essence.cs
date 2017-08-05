using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DougieMcDungeons.Classes
{
    public class Essence
    {
        public string name;
        //private string firstName;
        public string suffixName;
        public string location;
        //public string descrip;
        public List<Stats> mods = new List<Stats>();

        public Essence(string n)
        {
            name = n;

            using (var reader = new StringReader(Properties.Resources.essence))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    if (values[0] == name)
                    {
                        location = values[1];
                        suffixName = values[2];
                        for (int i = 3; i < values.Length; i++)
                        {
                            mods.Add(new Stats(values[i], Convert.ToInt32(values[i + 1])));
                            i++;
                        }
                        break;
                    }
                }
            }
        }
    }
}
