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
    public partial class Inventory : Form
    {
        public Player _player;
        public List<Equipment> _equipList;
        public List<Essence> _essenceList;

        public Inventory(Player p)
        {
            InitializeComponent();
            _player = p;
            _equipList = p.equipmentInventory;
            _essenceList = p.essenceInventory;
        }

        private void equipButton_Click(object sender, EventArgs e)
        {
            if (equipmentListBox.SelectedIndex >= 0)
            {
                switch (_equipList[equipmentListBox.SelectedIndex].location)
                {
                    case "Head":
                        _player.head = _equipList[equipmentListBox.SelectedIndex];
                        break;
                    case "Chest":
                        _player.chest = _equipList[equipmentListBox.SelectedIndex];
                        break;
                    case "Legs":
                        _player.legs = _equipList[equipmentListBox.SelectedIndex];
                        break;
                    case "Hands":
                        _player.hands = _equipList[equipmentListBox.SelectedIndex];
                        break;
                    case "Feet":
                        _player.feet = _equipList[equipmentListBox.SelectedIndex];
                        break;
                    case "Weapon":
                        _player.weapon = _equipList[equipmentListBox.SelectedIndex];
                        break;
                    default:
                        break;
                }
            }
        }

        private void imbueButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteEquip_Click(object sender, EventArgs e)
        {
            if (equipmentListBox.SelectedIndex >= 0)
            {
                _player.equipmentInventory.RemoveAt(equipmentListBox.SelectedIndex);
                equipmentListBox.Items.RemoveAt(equipmentListBox.SelectedIndex);
            }
        }

        private void Inventory_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < _equipList.Count; i++)
            {
                equipmentListBox.Items.Add(_equipList[i].name);
            }
            for (int i = 0; i < _essenceList.Count; i++)
            {
                essenceListBox.Items.Add(_essenceList[i].name);
            }
        }

        private void essenceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (essenceListBox.SelectedIndex >= 0)
            {
                sNameLabel.Text = "Name: " + _essenceList[essenceListBox.SelectedIndex].name;
                sLocLabel.Text = "Equip: " + _essenceList[essenceListBox.SelectedIndex].location;
                sModsLabel.Text = "Modifiers: ";
                if (_essenceList[essenceListBox.SelectedIndex].mods.Count > 0)
                {
                    for (int i = 0; i < _essenceList[essenceListBox.SelectedIndex].mods.Count; i++)
                    {
                        sModsLabel.Text += _essenceList[essenceListBox.SelectedIndex].mods[i].statistic + " +" + _essenceList[essenceListBox.SelectedIndex].mods[i].magnitude + "\r\n";
                    }
                }
            }
            else
            {
                sNameLabel.Text = "Name: ";
                sLocLabel.Text = "Equip: ";
                sModsLabel.Text = "Modifiers: \r\n";
            }
        }

        private void equipmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (equipmentListBox.SelectedIndex >= 0)
            {
                eNameLabel.Text = "Name: " + _equipList[equipmentListBox.SelectedIndex].name;
                eLocLabel.Text = "Equip: " + _equipList[equipmentListBox.SelectedIndex].location;
                eSlotLabel.Text = "Slots: " + _equipList[equipmentListBox.SelectedIndex].slots.ToString();
                eModsLabel.Text = "Modifiers: ";
                if (_equipList[equipmentListBox.SelectedIndex].mods.Count > 0)
                {
                    for (int i = 0; i < _equipList[equipmentListBox.SelectedIndex].mods.Count; i++)
                    {
                        eModsLabel.Text += _equipList[equipmentListBox.SelectedIndex].mods[i].statistic + " +" + _equipList[equipmentListBox.SelectedIndex].mods[i].magnitude + "\r\n";
                    }
                }
                if (_equipList[equipmentListBox.SelectedIndex].ess != null)
                {
                    for (int i = 0; i < _equipList[equipmentListBox.SelectedIndex].ess.mods.Count; i++)
                    {
                        eModsLabel.Text += _equipList[equipmentListBox.SelectedIndex].ess.mods[i].statistic + " +" + _equipList[equipmentListBox.SelectedIndex].ess.mods[i].magnitude + "\r\n";
                    }
                }
            }
            else
            {
                eNameLabel.Text = "Name: ";
                eLocLabel.Text = "Equip: ";
                eSlotLabel.Text = "Slots: ";
                eModsLabel.Text = "Modifiers: \r\n";
            }
        }

        private void Inventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_player.head != null)
            {
                if (!_equipList.Contains(_player.head))
                {
                    _player.head = null;
                }
            }
            if (_player.chest != null)
            {
                if (!_equipList.Contains(_player.chest))
                {
                    _player.chest = null;
                }
            }
            if (_player.legs != null)
            {
                if (!_equipList.Contains(_player.legs))
                {
                    _player.legs = null;
                }
            }
            if (_player.hands != null)
            {
                if (!_equipList.Contains(_player.hands))
                {
                    _player.hands = null;
                }
            }
            if (_player.feet != null)
            {
                if (!_equipList.Contains(_player.feet))
                {
                    _player.feet = null;
                }
            }
            if (_player.weapon != null)
            {
                if (!_equipList.Contains(_player.weapon))
                {
                    _player.weapon = null;
                }
            }
            _player.addModsValue();
            Form1.UpdateForm.NewFormEvent(3, null);
        }

        private void deleteEssence_Click(object sender, EventArgs e)
        {
            if (essenceListBox.SelectedIndex >= 0)
            {
                _player.essenceInventory.RemoveAt(essenceListBox.SelectedIndex);
                essenceListBox.Items.RemoveAt(essenceListBox.SelectedIndex);
            }
        }
    }
}
