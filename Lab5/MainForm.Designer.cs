namespace Lab5
{
    partial class MainForm
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
            this.configurationScriptLabel = new System.Windows.Forms.Label();
            this.lineClipButton = new System.Windows.Forms.Button();
            this.configurationScriptInputBox = new System.Windows.Forms.TextBox();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // configurationScriptLabel
            // 
            this.configurationScriptLabel.AutoSize = true;
            this.configurationScriptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.configurationScriptLabel.ForeColor = System.Drawing.Color.Black;
            this.configurationScriptLabel.Location = new System.Drawing.Point(178, 24);
            this.configurationScriptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.configurationScriptLabel.Name = "configurationScriptLabel";
            this.configurationScriptLabel.Size = new System.Drawing.Size(127, 29);
            this.configurationScriptLabel.TabIndex = 2;
            this.configurationScriptLabel.Text = "Input data";
            this.configurationScriptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lineClipButton
            // 
            this.lineClipButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lineClipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineClipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineClipButton.ForeColor = System.Drawing.Color.Black;
            this.lineClipButton.Location = new System.Drawing.Point(575, 604);
            this.lineClipButton.Margin = new System.Windows.Forms.Padding(4);
            this.lineClipButton.Name = "lineClipButton";
            this.lineClipButton.Size = new System.Drawing.Size(279, 52);
            this.lineClipButton.TabIndex = 3;
            this.lineClipButton.Text = "Clip";
            this.lineClipButton.UseVisualStyleBackColor = true;
            this.lineClipButton.Click += new System.EventHandler(this.lineClipButton_Click);
            // 
            // configurationScriptInputBox
            // 
            this.configurationScriptInputBox.BackColor = System.Drawing.Color.White;
            this.configurationScriptInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.configurationScriptInputBox.ForeColor = System.Drawing.Color.Black;
            this.configurationScriptInputBox.Location = new System.Drawing.Point(13, 57);
            this.configurationScriptInputBox.Margin = new System.Windows.Forms.Padding(4);
            this.configurationScriptInputBox.Multiline = true;
            this.configurationScriptInputBox.Name = "configurationScriptInputBox";
            this.configurationScriptInputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.configurationScriptInputBox.Size = new System.Drawing.Size(489, 539);
            this.configurationScriptInputBox.TabIndex = 5;
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Location = new System.Drawing.Point(510, 24);
            this.resultPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(785, 572);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultPictureBox.TabIndex = 1;
            this.resultPictureBox.TabStop = false;
            this.resultPictureBox.Click += new System.EventHandler(this.resultPictureBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1326, 669);
            this.Controls.Add(this.configurationScriptLabel);
            this.Controls.Add(this.lineClipButton);
            this.Controls.Add(this.configurationScriptInputBox);
            this.Controls.Add(this.resultPictureBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Lab5_Katsuba_12gr";
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.Label configurationScriptLabel;
        private System.Windows.Forms.Button lineClipButton;
        private System.Windows.Forms.TextBox configurationScriptInputBox;
    }
}

