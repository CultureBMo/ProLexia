using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLexia
{
    public partial class OptionsForm : Form
    {
        private string overlayColor = string.Empty;

        public OptionsForm()
        {
            InitializeComponent();
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colourTextBox.BackColor = colorDialog.Color;

                var mainForm = this.Owner;
                mainForm.BackColor = colorDialog.Color;
            }
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            var mainForm = this.Owner;
            colourTextBox.BackColor = mainForm.BackColor;
            colorDialog.Color = mainForm.BackColor;
        }
    }
}