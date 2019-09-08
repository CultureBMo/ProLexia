namespace ProLexia
{
    using System;
    using System.Windows.Forms;

    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            this.InitializeComponent();
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            if (this.colorDialog.ShowDialog() == DialogResult.OK)
            {
                var chosenColor = this.colorDialog.Color;

                this.colorTextBox.BackColor = chosenColor;
                this.Owner.BackColor = chosenColor;

                Properties.Settings.Default.OverlayRed = chosenColor.R;
                Properties.Settings.Default.OverlayGreen = chosenColor.G;
                Properties.Settings.Default.OverlayBlue = chosenColor.B;
                Properties.Settings.Default.Save();
            }
        }

        private void OpacityTrackBar_Scroll(object sender, EventArgs e)
        {
            var chosenOpacity = this.opacityTrackBar.Value;

            var mainForm = this.Owner as MainForm;
            mainForm.OverlayOpacity = chosenOpacity;

            Properties.Settings.Default.Opacity = chosenOpacity;
            Properties.Settings.Default.Save();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            var mainForm = this.Owner as MainForm;

            this.colorTextBox.BackColor = mainForm.BackColor;
            this.colorDialog.Color = mainForm.BackColor;
            this.opacityTrackBar.Value = mainForm.OverlayOpacity;
        }
    }
}