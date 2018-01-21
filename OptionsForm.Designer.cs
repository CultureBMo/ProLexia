namespace ProLexia
{
    public partial class OptionsForm
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.chooseButton = new System.Windows.Forms.Button();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.opacityLabel = new System.Windows.Forms.Label();
            this.opacityTrackBar = new System.Windows.Forms.TrackBar();
            this.copyrightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(177, 11);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(59, 23);
            this.chooseButton.TabIndex = 1;
            this.chooseButton.Text = "Choose";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(71, 13);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox.TabIndex = 1;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(12, 16);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(40, 13);
            this.colorLabel.TabIndex = 0;
            this.colorLabel.Text = "Colour:";
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // opacityLabel
            // 
            this.opacityLabel.AutoSize = true;
            this.opacityLabel.Location = new System.Drawing.Point(12, 50);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(46, 13);
            this.opacityLabel.TabIndex = 2;
            this.opacityLabel.Text = "Opacity:";
            // 
            // opacityTrackBar
            // 
            this.opacityTrackBar.Location = new System.Drawing.Point(64, 50);
            this.opacityTrackBar.Maximum = 255;
            this.opacityTrackBar.Name = "opacityTrackBar";
            this.opacityTrackBar.Size = new System.Drawing.Size(181, 45);
            this.opacityTrackBar.TabIndex = 3;
            this.opacityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.opacityTrackBar.Value = 128;
            this.opacityTrackBar.Scroll += new System.EventHandler(this.OpacityTrackBar_Scroll);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.copyrightLabel.Location = new System.Drawing.Point(97, 93);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(148, 13);
            this.copyrightLabel.TabIndex = 4;
            this.copyrightLabel.Text = "Copyright © CultureBMo 2018";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 115);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.opacityTrackBar);
            this.Controls.Add(this.opacityLabel);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.colorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProLexia Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label opacityLabel;
        private System.Windows.Forms.TrackBar opacityTrackBar;
        private System.Windows.Forms.Label copyrightLabel;
    }
}