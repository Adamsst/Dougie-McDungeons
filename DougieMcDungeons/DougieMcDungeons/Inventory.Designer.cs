namespace DougieMcDungeons
{
    partial class Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imbueButton = new System.Windows.Forms.Button();
            this.sModsLabel = new System.Windows.Forms.Label();
            this.sLocLabel = new System.Windows.Forms.Label();
            this.sNameLabel = new System.Windows.Forms.Label();
            this.essenceListBox = new System.Windows.Forms.ListBox();
            this.deleteEquip = new System.Windows.Forms.Button();
            this.eModsLabel = new System.Windows.Forms.Label();
            this.eSlotLabel = new System.Windows.Forms.Label();
            this.eLocLabel = new System.Windows.Forms.Label();
            this.eNameLabel = new System.Windows.Forms.Label();
            this.equipButton = new System.Windows.Forms.Button();
            this.equipmentLabel = new System.Windows.Forms.Label();
            this.equipmentListBox = new System.Windows.Forms.ListBox();
            this.deleteEssence = new System.Windows.Forms.Button();
            this.unequipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imbueButton
            // 
            this.imbueButton.Location = new System.Drawing.Point(606, 222);
            this.imbueButton.Name = "imbueButton";
            this.imbueButton.Size = new System.Drawing.Size(75, 23);
            this.imbueButton.TabIndex = 26;
            this.imbueButton.Text = "Imbue";
            this.imbueButton.UseVisualStyleBackColor = true;
            this.imbueButton.Click += new System.EventHandler(this.imbueButton_Click);
            // 
            // sModsLabel
            // 
            this.sModsLabel.AutoSize = true;
            this.sModsLabel.Location = new System.Drawing.Point(603, 67);
            this.sModsLabel.Name = "sModsLabel";
            this.sModsLabel.Size = new System.Drawing.Size(52, 13);
            this.sModsLabel.TabIndex = 25;
            this.sModsLabel.Text = "Modifiers:";
            // 
            // sLocLabel
            // 
            this.sLocLabel.AutoSize = true;
            this.sLocLabel.Location = new System.Drawing.Point(603, 49);
            this.sLocLabel.Name = "sLocLabel";
            this.sLocLabel.Size = new System.Drawing.Size(40, 13);
            this.sLocLabel.TabIndex = 24;
            this.sLocLabel.Text = "Equip: ";
            // 
            // sNameLabel
            // 
            this.sNameLabel.AutoSize = true;
            this.sNameLabel.Location = new System.Drawing.Point(602, 32);
            this.sNameLabel.Name = "sNameLabel";
            this.sNameLabel.Size = new System.Drawing.Size(38, 13);
            this.sNameLabel.TabIndex = 23;
            this.sNameLabel.Text = "Name:";
            // 
            // essenceListBox
            // 
            this.essenceListBox.FormattingEnabled = true;
            this.essenceListBox.Location = new System.Drawing.Point(397, 32);
            this.essenceListBox.Name = "essenceListBox";
            this.essenceListBox.Size = new System.Drawing.Size(200, 264);
            this.essenceListBox.TabIndex = 22;
            this.essenceListBox.SelectedIndexChanged += new System.EventHandler(this.essenceListBox_SelectedIndexChanged);
            // 
            // deleteEquip
            // 
            this.deleteEquip.Location = new System.Drawing.Point(256, 256);
            this.deleteEquip.Name = "deleteEquip";
            this.deleteEquip.Size = new System.Drawing.Size(75, 37);
            this.deleteEquip.TabIndex = 21;
            this.deleteEquip.Text = "Delete Equipment";
            this.deleteEquip.UseVisualStyleBackColor = true;
            this.deleteEquip.Click += new System.EventHandler(this.deleteEquip_Click);
            // 
            // eModsLabel
            // 
            this.eModsLabel.AutoSize = true;
            this.eModsLabel.Location = new System.Drawing.Point(253, 70);
            this.eModsLabel.Name = "eModsLabel";
            this.eModsLabel.Size = new System.Drawing.Size(50, 13);
            this.eModsLabel.TabIndex = 20;
            this.eModsLabel.Text = "Modfiers:";
            // 
            // eSlotLabel
            // 
            this.eSlotLabel.AutoSize = true;
            this.eSlotLabel.Location = new System.Drawing.Point(253, 53);
            this.eSlotLabel.Name = "eSlotLabel";
            this.eSlotLabel.Size = new System.Drawing.Size(33, 13);
            this.eSlotLabel.TabIndex = 19;
            this.eSlotLabel.Text = "Slots:";
            // 
            // eLocLabel
            // 
            this.eLocLabel.AutoSize = true;
            this.eLocLabel.Location = new System.Drawing.Point(253, 35);
            this.eLocLabel.Name = "eLocLabel";
            this.eLocLabel.Size = new System.Drawing.Size(40, 13);
            this.eLocLabel.TabIndex = 18;
            this.eLocLabel.Text = "Equip: ";
            // 
            // eNameLabel
            // 
            this.eNameLabel.AutoSize = true;
            this.eNameLabel.Location = new System.Drawing.Point(252, 18);
            this.eNameLabel.Name = "eNameLabel";
            this.eNameLabel.Size = new System.Drawing.Size(38, 13);
            this.eNameLabel.TabIndex = 17;
            this.eNameLabel.Text = "Name:";
            // 
            // equipButton
            // 
            this.equipButton.Location = new System.Drawing.Point(255, 188);
            this.equipButton.Name = "equipButton";
            this.equipButton.Size = new System.Drawing.Size(75, 23);
            this.equipButton.TabIndex = 16;
            this.equipButton.Text = "Equip";
            this.equipButton.UseVisualStyleBackColor = true;
            this.equipButton.Click += new System.EventHandler(this.equipButton_Click);
            // 
            // equipmentLabel
            // 
            this.equipmentLabel.AutoSize = true;
            this.equipmentLabel.Location = new System.Drawing.Point(13, 16);
            this.equipmentLabel.Name = "equipmentLabel";
            this.equipmentLabel.Size = new System.Drawing.Size(57, 13);
            this.equipmentLabel.TabIndex = 15;
            this.equipmentLabel.Text = "Equipment";
            // 
            // equipmentListBox
            // 
            this.equipmentListBox.FormattingEnabled = true;
            this.equipmentListBox.Location = new System.Drawing.Point(14, 32);
            this.equipmentListBox.Name = "equipmentListBox";
            this.equipmentListBox.Size = new System.Drawing.Size(232, 264);
            this.equipmentListBox.TabIndex = 14;
            this.equipmentListBox.SelectedIndexChanged += new System.EventHandler(this.equipmentListBox_SelectedIndexChanged);
            // 
            // deleteEssence
            // 
            this.deleteEssence.Location = new System.Drawing.Point(606, 256);
            this.deleteEssence.Name = "deleteEssence";
            this.deleteEssence.Size = new System.Drawing.Size(75, 37);
            this.deleteEssence.TabIndex = 27;
            this.deleteEssence.Text = "Delete Essence";
            this.deleteEssence.UseVisualStyleBackColor = true;
            this.deleteEssence.Click += new System.EventHandler(this.deleteEssence_Click);
            // 
            // unequipButton
            // 
            this.unequipButton.Location = new System.Drawing.Point(256, 222);
            this.unequipButton.Name = "unequipButton";
            this.unequipButton.Size = new System.Drawing.Size(75, 23);
            this.unequipButton.TabIndex = 28;
            this.unequipButton.Text = "Unequip";
            this.unequipButton.UseVisualStyleBackColor = true;
            this.unequipButton.Click += new System.EventHandler(this.unequipButton_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 312);
            this.Controls.Add(this.unequipButton);
            this.Controls.Add(this.deleteEssence);
            this.Controls.Add(this.imbueButton);
            this.Controls.Add(this.sModsLabel);
            this.Controls.Add(this.sLocLabel);
            this.Controls.Add(this.sNameLabel);
            this.Controls.Add(this.essenceListBox);
            this.Controls.Add(this.deleteEquip);
            this.Controls.Add(this.eModsLabel);
            this.Controls.Add(this.eSlotLabel);
            this.Controls.Add(this.eLocLabel);
            this.Controls.Add(this.eNameLabel);
            this.Controls.Add(this.equipButton);
            this.Controls.Add(this.equipmentLabel);
            this.Controls.Add(this.equipmentListBox);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inventory_FormClosing);
            this.Shown += new System.EventHandler(this.Inventory_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button imbueButton;
        private System.Windows.Forms.Label sModsLabel;
        private System.Windows.Forms.Label sLocLabel;
        private System.Windows.Forms.Label sNameLabel;
        public System.Windows.Forms.ListBox essenceListBox;
        private System.Windows.Forms.Button deleteEquip;
        private System.Windows.Forms.Label eModsLabel;
        private System.Windows.Forms.Label eSlotLabel;
        private System.Windows.Forms.Label eLocLabel;
        private System.Windows.Forms.Label eNameLabel;
        private System.Windows.Forms.Button equipButton;
        private System.Windows.Forms.Label equipmentLabel;
        public System.Windows.Forms.ListBox equipmentListBox;
        private System.Windows.Forms.Button deleteEssence;
        private System.Windows.Forms.Button unequipButton;
    }
}