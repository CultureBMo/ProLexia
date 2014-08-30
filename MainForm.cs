namespace ProLexia
{
    using System;
    using System.Configuration;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private System.Windows.Forms.ContextMenu contextMenu;
        private System.Windows.Forms.MenuItem exitCommand;
        private System.Windows.Forms.MenuItem optionsCommand;
        private byte overlayOpacity = 128;

        public MainForm()
        {
            this.InitializeComponent();

            this.optionsCommand = new System.Windows.Forms.MenuItem();
            this.optionsCommand.Index = 0;
            this.optionsCommand.Text = "O&ptions";
            this.optionsCommand.Click += new System.EventHandler(this.OptionsCommand_Click);

            this.exitCommand = new System.Windows.Forms.MenuItem();
            this.exitCommand.Index = 1;
            this.exitCommand.Text = "Ex&it";
            this.exitCommand.Click += new System.EventHandler(this.ExitCommand_Click);

            this.contextMenu = new System.Windows.Forms.ContextMenu();
            this.contextMenu.MenuItems.AddRange(new[] { this.optionsCommand, this.exitCommand });

            this.notifyIcon.Icon = new Icon("Janik-Baumgartner-Woocons-Chart-Pie.ico");
            this.notifyIcon.ContextMenu = this.contextMenu;
            this.notifyIcon.Visible = true;

            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.BackColor = this.GetColorFromConfig();
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;

            this.OverlayOpacity = this.GetOpacityFromConfig();
        }

        public byte OverlayOpacity
        {
            get
            {
                return this.overlayOpacity;
            }

            set
            {
                this.overlayOpacity = value;

                this.SetWindow();
            }
        }

        private void ExitCommand_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Color GetColorFromConfig()
        {
            var overlayColor = ConfigurationManager.AppSettings["OverlayColor"] ?? "128, 255, 128";

            var colors = overlayColor.Split(',');

            int red = this.GetInt(colors[0]);
            int green = this.GetInt(colors[1]);
            int blue = this.GetInt(colors[2]);

            return System.Drawing.Color.FromArgb(red, green, blue);
        }

        private int GetInt(string colorString)
        {
            int returnInt = 0;

            int.TryParse(colorString.Trim(), out returnInt);

            return returnInt;
        }

        private byte GetOpacityFromConfig()
        {
            var opacity = ConfigurationManager.AppSettings["Opacity"] ?? "128";

            int opacityValue = this.GetInt(opacity);

            return Convert.ToByte(opacityValue);
        }

        private void OptionsCommand_Click(object sender, EventArgs e)
        {
            var optionsForm = new OptionsForm();
            optionsForm.ShowDialog(this);
        }

        private void SetWindow()
        {
            int wl = NativeMethods.GetWindowLong(this.Handle, NativeMethods.GWL.ExStyle);
            wl = wl | 0x80000 | 0x20;
            NativeMethods.SetWindowLong(this.Handle, NativeMethods.GWL.ExStyle, wl);
            NativeMethods.SetLayeredWindowAttributes(this.Handle, 0, this.overlayOpacity, NativeMethods.LWA.Alpha);
        }
    }
}