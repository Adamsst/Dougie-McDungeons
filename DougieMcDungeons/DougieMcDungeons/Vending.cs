using DougieMcDungeons.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DougieMcDungeons
{
    public partial class Vending : Form
    {
        private Vendor localVendor;

        public Vending(string name,string type)
        {
            InitializeComponent();
            if(type == "skill")
            {
                localVendor = new skillVendor("Octavius");
            }
        }

        private void Vending_Load(object sender, EventArgs e)
        {
            vendorNameLabel.Text = "Vendor: " + localVendor.name + ", " + localVendor.vendorType + " dealer";
            if(localVendor.vendorType == "skill")
            {
                foreach(string s in localVendor.forSale)
                {
                    vendListBox.Items.Add(s);
                }
            }
        }

        private void Vending_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.UpdateForm.NewFormEvent(3, null);
        }

        private void vendListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
