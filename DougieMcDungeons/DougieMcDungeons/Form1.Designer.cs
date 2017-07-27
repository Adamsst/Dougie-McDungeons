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
            this.coordinatesLabel.Size = new System.Drawing.Size(66, 13);
            this.coordinatesLabel.TabIndex = 0;
            this.coordinatesLabel.Text = "Coordinates:";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 762);
            this.Controls.Add(this.mapLabel);
            this.Controls.Add(this.coordinatesLabel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Dougie McDungeons";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer movementTimer;
        private System.Windows.Forms.Label coordinatesLabel;
        private System.Windows.Forms.Label mapLabel;
    }
}

