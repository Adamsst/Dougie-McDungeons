using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DougieMcDungeons.Classes
{
    public class Vendor
    {
        public List<int> costs = new List<int>();
        public List<string> forSale = new List<string>();
        public string vendorType = "neutral";//skill,equipment,essence
        public Image img;
        public int xLoc = 0;
        public int yLoc = 0;
        public string name = null;
        public Vendor(string vendorName)
        {
            name = vendorName;
            using (var reader = new StringReader(Properties.Resources.vendors))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    if (values[0] == vendorName)
                    {
                        for (int i = 1; i < values.Length; i++)
                        {
                            forSale.Add(values[i]);
                            i++;
                            costs.Add(Convert.ToInt32(values[i]));
                        }
                    }
                }
            }
        }
    }

    public class skillVendor : Vendor
    {
        private List<Skill> skillsForSale = new List<Skill>();

        public skillVendor(string vendorName) : base(vendorName)
        {
            if(vendorName == "Octavius")
            {
                vendorType = "skill";
                img = Properties.Resources.player1;
                xLoc = 4;
                yLoc = 4;
            }

            //foreach(string s in forSale)
            //{
                //if(s == "Simple Strike")
                //{
                    //skillsForSale.Add(new SimpleStrike(null));
                //}
            //}
        }
    }

}
