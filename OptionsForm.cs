namespace ProLexia
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Configuration;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class OptionsForm : Form
    {
        private string overlayColor = string.Empty;

        public OptionsForm()
        {
            InitializeComponent();
        }

        private static void SaveToConfig(string key, string value)
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

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorTextBox.BackColor = colorDialog.Color;

                this.Owner.BackColor = colorDialog.Color;

                SaveColorToConfig(colorDialog.Color);
            }
        }

        private void opacityTrackBar_Scroll(object sender, EventArgs e)
        {
            var mainForm = this.Owner as MainForm;
            mainForm.OverlayOpacity = Convert.ToByte(this.opacityTrackBar.Value);

            SaveOpacityToConfig(this.opacityTrackBar.Value);
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            var mainForm = this.Owner as MainForm;

            colorTextBox.BackColor = mainForm.BackColor;
            colorDialog.Color = mainForm.BackColor;

            opacityTrackBar.Value = mainForm.OverlayOpacity;
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