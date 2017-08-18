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
    public partial class Skills : Form
    {
        public Player _player;
        private List<Skill> _skillList;
        private List<ComboBox> _controlList;

        public Skills(Player p)
        {
            InitializeComponent();
            _player = p;
            _skillList = _player.skillInventory;
            _controlList = new List<ComboBox>();

            comboBox1.DataSource = new BindingSource(_skillList, null);
            comboBox1.DisplayMember = "name";

            _controlList.Add(comboBox1);
            _controlList.Add(comboBox2);
            _controlList.Add(comboBox3);
            _controlList.Add(comboBox4);
            _controlList.Add(comboBox5);
            _controlList.Add(comboBox6);
            _controlList.Add(comboBox7);
            _controlList.Add(comboBox8);
            _controlList.Add(comboBox9);

            for(int i = 0; i <= 8; i++)
            {
                _controlList[i].DataSource = new BindingSource(_skillList, null);
                _controlList[i].DisplayMember = "name";
                _controlList[i].SelectedItem = _player.skillSet[(i + 1)];
                _controlList[i].SelectedIndexChanged += comboBoxSkillChanged;
            }

        }

        private void comboBoxSkillChanged(object sender, EventArgs e)
        {
            ComboBox causeOfEvent = (ComboBox)sender;

            if (causeOfEvent.Text != "None")
            {
                foreach (ComboBox c in _controlList)
                {
                    if(c.Text.Equals(causeOfEvent.Text) && c != causeOfEvent)
                    {
                        c.SelectedIndex = 0;
                    }
                }
            }
        }

        private void Skills_FormClosing(object sender, FormClosingEventArgs e)
        {
            for(int i = 1; i <= 9; i++)
            {
                _player.skillSet[i] = _skillList[_controlList[i - 1].SelectedIndex];
            }
            Form1.UpdateForm.NewFormEvent(5, null);
        }
    }
}
