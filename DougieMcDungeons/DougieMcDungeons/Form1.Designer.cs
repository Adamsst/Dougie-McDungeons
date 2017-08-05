namespace DougieMcDungeons
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.coordinatesLabel = new System.Windows.Forms.Label();
            this.mapLabel = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.ListBox();
            this.healthLabel = new System.Windows.Forms.Label();
            this.atkLabel = new System.Windows.Forms.Label();
            this.defLabel = new System.Windows.Forms.Label();
            this.matkLabel = new System.Windows.Forms.Label();
            this.atkcritLabel = new System.Windows.Forms.Label();
            this.mdefLabel = new System.Windows.Forms.Label();
            this.atkhitLabel = new System.Windows.Forms.Label();
            this.matkcritLabel = new System.Windows.Forms.Label();
            this.matkhitLabel = new System.Windows.Forms.Label();
            this.headText = new System.Windows.Forms.Label();
            this.headLabel = new System.Windows.Forms.Label();
            this.chestText = new System.Windows.Forms.Label();
            this.chestLabel = new System.Windows.Forms.Label();
            this.legsLabel = new System.Windows.Forms.Label();
            this.legsText = new System.Windows.Forms.Label();
            this.handsLabel = new System.Windows.Forms.Label();
            this.handsText = new System.Windows.Forms.Label();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.weaponText = new System.Windows.Forms.Label();
            this.feetLabel = new System.Windows.Forms.Label();
            this.feetText = new System.Windows.Forms.Label();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.oneLabel = new System.Windows.Forms.Label();
            this.sixLabel = new System.Windows.Forms.Label();
            this.twoLabel = new System.Windows.Forms.Label();
            this.threelabel = new System.Windows.Forms.Label();
            this.fourLabel = new System.Windows.Forms.Label();
            this.sevenLabel = new System.Windows.Forms.Label();
            this.eightLabel = new System.Windows.Forms.Label();
            this.nineLabel = new System.Windows.Forms.Label();
            this.zeroLabel = new System.Windows.Forms.Label();
            this.fiveLabel = new System.Windows.Forms.Label();
            this.skill1Picture = new System.Windows.Forms.PictureBox();
            this.skill2Picture = new System.Windows.Forms.PictureBox();
            this.skill3Picture = new System.Windows.Forms.PictureBox();
            this.skill4Picture = new System.Windows.Forms.PictureBox();
            this.skill5Picture = new System.Windows.Forms.PictureBox();
            this.skill6Picture = new System.Windows.Forms.PictureBox();
            this.skill7Picture = new System.Windows.Forms.PictureBox();
            this.skill8Picture = new System.Windows.Forms.PictureBox();
            this.skill9Picture = new System.Windows.Forms.PictureBox();
            this.skill0Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.skill1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill3Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill4Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill5Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill6Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill7Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill8Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill9Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill0Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // movementTimer
            // 
            this.movementTimer.Tick += new System.EventHandler(this.movementTimer_Tick);
            // 
            // coordinatesLabel
            // 
            this.coordinatesLabel.AutoSize = true;
            this.coordinatesLabel.Location = new System.Drawing.Point(367, 179);
            this.coordinatesLabel.Name = "coordinatesLabel";
            this.coordinatesLabel.Size = new System.Drawing.Size(28, 13);
            this.coordinatesLabel.TabIndex = 0;
            this.coordinatesLabel.Text = "Test";
            // 
            // mapLabel
            // 
            this.mapLabel.AutoSize = true;
            this.mapLabel.Location = new System.Drawing.Point(367, 166);
            this.mapLabel.Name = "mapLabel";
            this.mapLabel.Size = new System.Drawing.Size(68, 13);
            this.mapLabel.TabIndex = 1;
            this.mapLabel.Text = "Current Map:";
            // 
            // messageBox
            // 
            this.messageBox.FormattingEnabled = true;
            this.messageBox.Location = new System.Drawing.Point(200, 655);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(425, 95);
            this.messageBox.TabIndex = 2;
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(633, 220);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(35, 13);
            this.healthLabel.TabIndex = 3;
            this.healthLabel.Text = "label1";
            // 
            // atkLabel
            // 
            this.atkLabel.AutoSize = true;
            this.atkLabel.Location = new System.Drawing.Point(633, 235);
            this.atkLabel.Name = "atkLabel";
            this.atkLabel.Size = new System.Drawing.Size(35, 13);
            this.atkLabel.TabIndex = 4;
            this.atkLabel.Text = "label2";
            // 
            // defLabel
            // 
            this.defLabel.AutoSize = true;
            this.defLabel.Location = new System.Drawing.Point(633, 265);
            this.defLabel.Name = "defLabel";
            this.defLabel.Size = new System.Drawing.Size(35, 13);
            this.defLabel.TabIndex = 6;
            this.defLabel.Text = "label3";
            // 
            // matkLabel
            // 
            this.matkLabel.AutoSize = true;
            this.matkLabel.Location = new System.Drawing.Point(633, 250);
            this.matkLabel.Name = "matkLabel";
            this.matkLabel.Size = new System.Drawing.Size(35, 13);
            this.matkLabel.TabIndex = 5;
            this.matkLabel.Text = "label4";
            // 
            // atkcritLabel
            // 
            this.atkcritLabel.AutoSize = true;
            this.atkcritLabel.Location = new System.Drawing.Point(633, 295);
            this.atkcritLabel.Name = "atkcritLabel";
            this.atkcritLabel.Size = new System.Drawing.Size(35, 13);
            this.atkcritLabel.TabIndex = 8;
            this.atkcritLabel.Text = "label5";
            // 
            // mdefLabel
            // 
            this.mdefLabel.AutoSize = true;
            this.mdefLabel.Location = new System.Drawing.Point(633, 280);
            this.mdefLabel.Name = "mdefLabel";
            this.mdefLabel.Size = new System.Drawing.Size(35, 13);
            this.mdefLabel.TabIndex = 7;
            this.mdefLabel.Text = "label6";
            // 
            // atkhitLabel
            // 
            this.atkhitLabel.AutoSize = true;
            this.atkhitLabel.Location = new System.Drawing.Point(633, 325);
            this.atkhitLabel.Name = "atkhitLabel";
            this.atkhitLabel.Size = new System.Drawing.Size(35, 13);
            this.atkhitLabel.TabIndex = 10;
            this.atkhitLabel.Text = "label7";
            // 
            // matkcritLabel
            // 
            this.matkcritLabel.AutoSize = true;
            this.matkcritLabel.Location = new System.Drawing.Point(633, 310);
            this.matkcritLabel.Name = "matkcritLabel";
            this.matkcritLabel.Size = new System.Drawing.Size(35, 13);
            this.matkcritLabel.TabIndex = 9;
            this.matkcritLabel.Text = "label8";
            // 
            // matkhitLabel
            // 
            this.matkhitLabel.AutoSize = true;
            this.matkhitLabel.Location = new System.Drawing.Point(633, 340);
            this.matkhitLabel.Name = "matkhitLabel";
            this.matkhitLabel.Size = new System.Drawing.Size(35, 13);
            this.matkhitLabel.TabIndex = 11;
            this.matkhitLabel.Text = "label9";
            // 
            // headText
            // 
            this.headText.AutoSize = true;
            this.headText.Location = new System.Drawing.Point(13, 220);
            this.headText.Name = "headText";
            this.headText.Size = new System.Drawing.Size(36, 13);
            this.headText.TabIndex = 12;
            this.headText.Text = "Head:";
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Location = new System.Drawing.Point(12, 235);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(33, 13);
            this.headLabel.TabIndex = 13;
            this.headLabel.Text = "None";
            // 
            // chestText
            // 
            this.chestText.AutoSize = true;
            this.chestText.Location = new System.Drawing.Point(12, 265);
            this.chestText.Name = "chestText";
            this.chestText.Size = new System.Drawing.Size(37, 13);
            this.chestText.TabIndex = 14;
            this.chestText.Text = "Chest:";
            // 
            // chestLabel
            // 
            this.chestLabel.AutoSize = true;
            this.chestLabel.Location = new System.Drawing.Point(12, 280);
            this.chestLabel.Name = "chestLabel";
            this.chestLabel.Size = new System.Drawing.Size(33, 13);
            this.chestLabel.TabIndex = 15;
            this.chestLabel.Text = "None";
            // 
            // legsLabel
            // 
            this.legsLabel.AutoSize = true;
            this.legsLabel.Location = new System.Drawing.Point(12, 369);
            this.legsLabel.Name = "legsLabel";
            this.legsLabel.Size = new System.Drawing.Size(33, 13);
            this.legsLabel.TabIndex = 19;
            this.legsLabel.Text = "None";
            // 
            // legsText
            // 
            this.legsText.AutoSize = true;
            this.legsText.Location = new System.Drawing.Point(12, 354);
            this.legsText.Name = "legsText";
            this.legsText.Size = new System.Drawing.Size(33, 13);
            this.legsText.TabIndex = 18;
            this.legsText.Text = "Legs:";
            // 
            // handsLabel
            // 
            this.handsLabel.AutoSize = true;
            this.handsLabel.Location = new System.Drawing.Point(12, 324);
            this.handsLabel.Name = "handsLabel";
            this.handsLabel.Size = new System.Drawing.Size(33, 13);
            this.handsLabel.TabIndex = 17;
            this.handsLabel.Text = "None";
            // 
            // handsText
            // 
            this.handsText.AutoSize = true;
            this.handsText.Location = new System.Drawing.Point(13, 309);
            this.handsText.Name = "handsText";
            this.handsText.Size = new System.Drawing.Size(41, 13);
            this.handsText.TabIndex = 16;
            this.handsText.Text = "Hands:";
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.Location = new System.Drawing.Point(11, 463);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(33, 13);
            this.weaponLabel.TabIndex = 23;
            this.weaponLabel.Text = "None";
            // 
            // weaponText
            // 
            this.weaponText.AutoSize = true;
            this.weaponText.Location = new System.Drawing.Point(11, 448);
            this.weaponText.Name = "weaponText";
            this.weaponText.Size = new System.Drawing.Size(51, 13);
            this.weaponText.TabIndex = 22;
            this.weaponText.Text = "Weapon:";
            // 
            // feetLabel
            // 
            this.feetLabel.AutoSize = true;
            this.feetLabel.Location = new System.Drawing.Point(11, 418);
            this.feetLabel.Name = "feetLabel";
            this.feetLabel.Size = new System.Drawing.Size(33, 13);
            this.feetLabel.TabIndex = 21;
            this.feetLabel.Text = "None";
            // 
            // feetText
            // 
            this.feetText.AutoSize = true;
            this.feetText.Location = new System.Drawing.Point(12, 403);
            this.feetText.Name = "feetText";
            this.feetText.Size = new System.Drawing.Size(31, 13);
            this.feetText.TabIndex = 20;
            this.feetText.Text = "Feet:";
            // 
            // inventoryButton
            // 
            this.inventoryButton.Location = new System.Drawing.Point(48, 672);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(98, 51);
            this.inventoryButton.TabIndex = 24;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // oneLabel
            // 
            this.oneLabel.AutoSize = true;
            this.oneLabel.Location = new System.Drawing.Point(206, 91);
            this.oneLabel.Name = "oneLabel";
            this.oneLabel.Size = new System.Drawing.Size(13, 13);
            this.oneLabel.TabIndex = 25;
            this.oneLabel.Text = "1";
            // 
            // sixLabel
            // 
            this.sixLabel.AutoSize = true;
            this.sixLabel.Location = new System.Drawing.Point(206, 142);
            this.sixLabel.Name = "sixLabel";
            this.sixLabel.Size = new System.Drawing.Size(13, 13);
            this.sixLabel.TabIndex = 26;
            this.sixLabel.Text = "6";
            // 
            // twoLabel
            // 
            this.twoLabel.AutoSize = true;
            this.twoLabel.Location = new System.Drawing.Point(306, 91);
            this.twoLabel.Name = "twoLabel";
            this.twoLabel.Size = new System.Drawing.Size(13, 13);
            this.twoLabel.TabIndex = 27;
            this.twoLabel.Text = "2";
            // 
            // threelabel
            // 
            this.threelabel.AutoSize = true;
            this.threelabel.Location = new System.Drawing.Point(406, 91);
            this.threelabel.Name = "threelabel";
            this.threelabel.Size = new System.Drawing.Size(13, 13);
            this.threelabel.TabIndex = 28;
            this.threelabel.Text = "3";
            // 
            // fourLabel
            // 
            this.fourLabel.AutoSize = true;
            this.fourLabel.Location = new System.Drawing.Point(506, 91);
            this.fourLabel.Name = "fourLabel";
            this.fourLabel.Size = new System.Drawing.Size(13, 13);
            this.fourLabel.TabIndex = 29;
            this.fourLabel.Text = "4";
            // 
            // sevenLabel
            // 
            this.sevenLabel.AutoSize = true;
            this.sevenLabel.Location = new System.Drawing.Point(306, 142);
            this.sevenLabel.Name = "sevenLabel";
            this.sevenLabel.Size = new System.Drawing.Size(13, 13);
            this.sevenLabel.TabIndex = 30;
            this.sevenLabel.Text = "7";
            // 
            // eightLabel
            // 
            this.eightLabel.AutoSize = true;
            this.eightLabel.Location = new System.Drawing.Point(406, 142);
            this.eightLabel.Name = "eightLabel";
            this.eightLabel.Size = new System.Drawing.Size(13, 13);
            this.eightLabel.TabIndex = 31;
            this.eightLabel.Text = "8";
            // 
            // nineLabel
            // 
            this.nineLabel.AutoSize = true;
            this.nineLabel.Location = new System.Drawing.Point(506, 142);
            this.nineLabel.Name = "nineLabel";
            this.nineLabel.Size = new System.Drawing.Size(13, 13);
            this.nineLabel.TabIndex = 32;
            this.nineLabel.Text = "9";
            // 
            // zeroLabel
            // 
            this.zeroLabel.AutoSize = true;
            this.zeroLabel.Location = new System.Drawing.Point(606, 142);
            this.zeroLabel.Name = "zeroLabel";
            this.zeroLabel.Size = new System.Drawing.Size(13, 13);
            this.zeroLabel.TabIndex = 33;
            this.zeroLabel.Text = "0";
            // 
            // fiveLabel
            // 
            this.fiveLabel.AutoSize = true;
            this.fiveLabel.Location = new System.Drawing.Point(606, 91);
            this.fiveLabel.Name = "fiveLabel";
            this.fiveLabel.Size = new System.Drawing.Size(13, 13);
            this.fiveLabel.TabIndex = 34;
            this.fiveLabel.Text = "5";
            // 
            // skill1Picture
            // 
            this.skill1Picture.Location = new System.Drawing.Point(200, 63);
            this.skill1Picture.Name = "skill1Picture";
            this.skill1Picture.Size = new System.Drawing.Size(25, 25);
            this.skill1Picture.TabIndex = 35;
            this.skill1Picture.TabStop = false;
            // 
            // skill2Picture
            // 
            this.skill2Picture.Location = new System.Drawing.Point(300, 63);
            this.skill2Picture.Name = "skill2Picture";
            this.skill2Picture.Size = new System.Drawing.Size(25, 25);
            this.skill2Picture.TabIndex = 36;
            this.skill2Picture.TabStop = false;
            // 
            // skill3Picture
            // 
            this.skill3Picture.Location = new System.Drawing.Point(400, 63);
            this.skill3Picture.Name = "skill3Picture";
            this.skill3Picture.Size = new System.Drawing.Size(25, 25);
            this.skill3Picture.TabIndex = 37;
            this.skill3Picture.TabStop = false;
            // 
            // skill4Picture
            // 
            this.skill4Picture.Location = new System.Drawing.Point(500, 63);
            this.skill4Picture.Name = "skill4Picture";
            this.skill4Picture.Size = new System.Drawing.Size(25, 25);
            this.skill4Picture.TabIndex = 38;
            this.skill4Picture.TabStop = false;
            // 
            // skill5Picture
            // 
            this.skill5Picture.Location = new System.Drawing.Point(600, 63);
            this.skill5Picture.Name = "skill5Picture";
            this.skill5Picture.Size = new System.Drawing.Size(25, 25);
            this.skill5Picture.TabIndex = 39;
            this.skill5Picture.TabStop = false;
            // 
            // skill6Picture
            // 
            this.skill6Picture.Location = new System.Drawing.Point(200, 115);
            this.skill6Picture.Name = "skill6Picture";
            this.skill6Picture.Size = new System.Drawing.Size(25, 25);
            this.skill6Picture.TabIndex = 40;
            this.skill6Picture.TabStop = false;
            // 
            // skill7Picture
            // 
            this.skill7Picture.Location = new System.Drawing.Point(300, 115);
            this.skill7Picture.Name = "skill7Picture";
            this.skill7Picture.Size = new System.Drawing.Size(25, 25);
            this.skill7Picture.TabIndex = 41;
            this.skill7Picture.TabStop = false;
            // 
            // skill8Picture
            // 
            this.skill8Picture.Location = new System.Drawing.Point(400, 115);
            this.skill8Picture.Name = "skill8Picture";
            this.skill8Picture.Size = new System.Drawing.Size(25, 25);
            this.skill8Picture.TabIndex = 42;
            this.skill8Picture.TabStop = false;
            // 
            // skill9Picture
            // 
            this.skill9Picture.Location = new System.Drawing.Point(500, 115);
            this.skill9Picture.Name = "skill9Picture";
            this.skill9Picture.Size = new System.Drawing.Size(25, 25);
            this.skill9Picture.TabIndex = 43;
            this.skill9Picture.TabStop = false;
            // 
            // skill0Picture
            // 
            this.skill0Picture.Location = new System.Drawing.Point(600, 115);
            this.skill0Picture.Name = "skill0Picture";
            this.skill0Picture.Size = new System.Drawing.Size(25, 25);
            this.skill0Picture.TabIndex = 44;
            this.skill0Picture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 762);
            this.Controls.Add(this.skill0Picture);
            this.Controls.Add(this.skill9Picture);
            this.Controls.Add(this.skill8Picture);
            this.Controls.Add(this.skill7Picture);
            this.Controls.Add(this.skill6Picture);
            this.Controls.Add(this.skill5Picture);
            this.Controls.Add(this.skill4Picture);
            this.Controls.Add(this.skill3Picture);
            this.Controls.Add(this.skill2Picture);
            this.Controls.Add(this.skill1Picture);
            this.Controls.Add(this.fiveLabel);
            this.Controls.Add(this.zeroLabel);
            this.Controls.Add(this.nineLabel);
            this.Controls.Add(this.eightLabel);
            this.Controls.Add(this.sevenLabel);
            this.Controls.Add(this.fourLabel);
            this.Controls.Add(this.threelabel);
            this.Controls.Add(this.twoLabel);
            this.Controls.Add(this.sixLabel);
            this.Controls.Add(this.oneLabel);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.weaponLabel);
            this.Controls.Add(this.weaponText);
            this.Controls.Add(this.feetLabel);
            this.Controls.Add(this.feetText);
            this.Controls.Add(this.legsLabel);
            this.Controls.Add(this.legsText);
            this.Controls.Add(this.handsLabel);
            this.Controls.Add(this.handsText);
            this.Controls.Add(this.chestLabel);
            this.Controls.Add(this.chestText);
            this.Controls.Add(this.headLabel);
            this.Controls.Add(this.headText);
            this.Controls.Add(this.matkhitLabel);
            this.Controls.Add(this.atkhitLabel);
            this.Controls.Add(this.matkcritLabel);
            this.Controls.Add(this.atkcritLabel);
            this.Controls.Add(this.mdefLabel);
            this.Controls.Add(this.defLabel);
            this.Controls.Add(this.matkLabel);
            this.Controls.Add(this.atkLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.mapLabel);
            this.Controls.Add(this.coordinatesLabel);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Dougie McDungeons";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.skill1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill3Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill4Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill5Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill6Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill7Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill8Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill9Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill0Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer movementTimer;
        private System.Windows.Forms.Label coordinatesLabel;
        private System.Windows.Forms.Label mapLabel;
        private System.Windows.Forms.ListBox messageBox;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label atkLabel;
        private System.Windows.Forms.Label defLabel;
        private System.Windows.Forms.Label matkLabel;
        private System.Windows.Forms.Label atkcritLabel;
        private System.Windows.Forms.Label mdefLabel;
        private System.Windows.Forms.Label atkhitLabel;
        private System.Windows.Forms.Label matkcritLabel;
        private System.Windows.Forms.Label matkhitLabel;
        private System.Windows.Forms.Label headText;
        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.Label chestText;
        private System.Windows.Forms.Label chestLabel;
        private System.Windows.Forms.Label legsLabel;
        private System.Windows.Forms.Label legsText;
        private System.Windows.Forms.Label handsLabel;
        private System.Windows.Forms.Label handsText;
        private System.Windows.Forms.Label weaponLabel;
        private System.Windows.Forms.Label weaponText;
        private System.Windows.Forms.Label feetLabel;
        private System.Windows.Forms.Label feetText;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Label oneLabel;
        private System.Windows.Forms.Label sixLabel;
        private System.Windows.Forms.Label twoLabel;
        private System.Windows.Forms.Label threelabel;
        private System.Windows.Forms.Label fourLabel;
        private System.Windows.Forms.Label sevenLabel;
        private System.Windows.Forms.Label eightLabel;
        private System.Windows.Forms.Label nineLabel;
        private System.Windows.Forms.Label zeroLabel;
        private System.Windows.Forms.Label fiveLabel;
        private System.Windows.Forms.PictureBox skill1Picture;
        private System.Windows.Forms.PictureBox skill2Picture;
        private System.Windows.Forms.PictureBox skill3Picture;
        private System.Windows.Forms.PictureBox skill4Picture;
        private System.Windows.Forms.PictureBox skill5Picture;
        private System.Windows.Forms.PictureBox skill6Picture;
        private System.Windows.Forms.PictureBox skill7Picture;
        private System.Windows.Forms.PictureBox skill8Picture;
        private System.Windows.Forms.PictureBox skill9Picture;
        private System.Windows.Forms.PictureBox skill0Picture;
    }
}

