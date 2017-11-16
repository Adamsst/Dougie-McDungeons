namespace DougieMcDungeons
{
    partial class Vending
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
            this.vendListBox = new System.Windows.Forms.ListBox();
            this.vendorNameLabel = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vendListBox
            // 
            this.vendListBox.FormattingEnabled = true;
            this.vendListBox.Location = new System.Drawing.Point(12, 28);
            this.vendListBox.Name = "vendListBox";
            this.vendListBox.Size = new System.Drawing.Size(210, 199);
            this.vendListBox.TabIndex = 0;
            this.vendListBox.SelectedIndexChanged += new System.EventHandler(this.vendListBox_SelectedIndexChanged);
            // 
            // vendorNameLabel
            // 
            this.vendorNameLabel.AutoSize = true;
            this.vendorNameLabel.Location = new System.Drawing.Point(13, 9);
            this.vendorNameLabel.Name = "vendorNameLabel";
            this.vendorNameLabel.Size = new System.Drawing.Size(47, 13);
            this.vendorNameLabel.TabIndex = 1;
            this.vendorNameLabel.Text = "Vendor: ";
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(286, 192);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 33);
            this.buyButton.TabIndex = 2;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            // 
            // Vending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 237);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.vendorNameLabel);
            this.Controls.Add(this.vendListBox);
            this.Name = "Vending";
            this.Text = "Vending";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vending_FormClosing);
            this.Load += new System.EventHandler(this.Vending_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox vendListBox;
        private System.Windows.Forms.Label vendorNameLabel;
        private System.Windows.Forms.Button buyButton;
    }
}