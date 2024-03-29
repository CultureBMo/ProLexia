namespace ProLexia
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Represents the options form of the application.
    /// </summary>
    public partial class OptionsForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsForm"/> class.
        /// </summary>
        public OptionsForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the ChooseButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Scroll event of the OpacityTrackBar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OpacityTrackBar_Scroll(object sender, EventArgs e)
        {
            var chosenOpacity = this.opacityTrackBar.Value;

            var mainForm = this.Owner as MainForm;
            mainForm.OverlayOpacity = chosenOpacity;

            Properties.Settings.Default.Opacity = chosenOpacity;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Handles the Load event of the OptionsForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OptionsForm_Load(object sender, EventArgs e)
        {
            var mainForm = this.Owner as MainForm;

            this.colorTextBox.BackColor = mainForm.BackColor;
            this.colorDialog.Color = mainForm.BackColor;
            this.opacityTrackBar.Value = mainForm.OverlayOpacity;
        }
    }
}