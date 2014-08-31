namespace ProLexia
{
    using System;
    using System.Configuration;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class OptionsForm : Form
    {
        private string overlayColor = string.Empty;

        public OptionsForm()
        {
            this.InitializeComponent();
        }

        private static void SaveToConfig(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;

                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }

                configFile.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch
            {
                MessageBox.Show("There was an error saving your options" + Environment.NewLine + "Please ensure your user account has Modify permissons to the ProLexia.config file");
            }
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            if (this.colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.colorTextBox.BackColor = this.colorDialog.Color;

                this.Owner.BackColor = this.colorDialog.Color;

                this.SaveColorToConfig(this.colorDialog.Color);
            }
        }

        private void OpacityTrackBar_Scroll(object sender, EventArgs e)
        {
            var mainForm = this.Owner as MainForm;
            mainForm.OverlayOpacity = Convert.ToByte(this.opacityTrackBar.Value);

            this.SaveOpacityToConfig(this.opacityTrackBar.Value);
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            var mainForm = this.Owner as MainForm;

            this.colorTextBox.BackColor = mainForm.BackColor;
            this.colorDialog.Color = mainForm.BackColor;

            this.opacityTrackBar.Value = mainForm.OverlayOpacity;
        }

        private void SaveColorToConfig(Color color)
        {
            var key = "OverlayColor";
            var value = string.Format("{0}, {1}, {2}", color.R, color.G, color.B);

            SaveToConfig(key, value);
        }

        private void SaveOpacityToConfig(int opacity)
        {
            var key = "Opacity";
            var value = opacity.ToString();

            SaveToConfig(key, value);
        }
    }
}