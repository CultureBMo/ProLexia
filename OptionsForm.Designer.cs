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
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.opacityTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(177, 10);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colour:";
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opacity:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(97, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Copyright © CultureBMo 2014";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 115);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.opacityTrackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar opacityTrackBar;
        private System.Windows.Forms.Label label3;
    }
}