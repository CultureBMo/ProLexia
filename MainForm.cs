namespace ProLexia
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using ProLexia.Properties;

    public partial class MainForm : Form
    {
        private System.Windows.Forms.ContextMenu contextMenu;
        private System.Windows.Forms.MenuItem exitCommand;
        private System.Windows.Forms.MenuItem optionsCommand;
        private int overlayOpacity;

        public MainForm()
        {
            this.InitializeComponent();

            this.optionsCommand = new System.Windows.Forms.MenuItem();
            this.optionsCommand.Index = 0;
            this.optionsCommand.Text = Resources.OptionsText;
            this.optionsCommand.Click += new System.EventHandler(this.OptionsCommand_Click);

            this.exitCommand = new System.Windows.Forms.MenuItem();
            this.exitCommand.Index = 1;
            this.exitCommand.Text = Resources.ExitText;
            this.exitCommand.Click += new System.EventHandler(this.ExitCommand_Click);

            this.contextMenu = new System.Windows.Forms.ContextMenu();
            this.contextMenu.MenuItems.AddRange(new[] { this.optionsCommand, this.exitCommand });

            this.notifyIcon.Icon = new Icon("Janik-Baumgartner-Woocons-Chart-Pie.ico");
            this.notifyIcon.ContextMenu = this.contextMenu;
            this.notifyIcon.Visible = true;

            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.BackColor = GetColorFromProperties();
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;

            this.OverlayOpacity = Properties.Settings.Default.Opacity;
        }

        public int OverlayOpacity
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

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            // method moved here from MainForm designer
            this.optionsCommand.Dispose();
            this.exitCommand.Dispose();
            this.contextMenu.Dispose();

            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        private static Color GetColorFromProperties()
        {
            var red = Properties.Settings.Default.OverlayRed;
            var green = Properties.Settings.Default.OverlayGreen;
            var blue = Properties.Settings.Default.OverlayBlue;

            return Color.FromArgb(red, green, blue);
        }

        private void ExitCommand_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OptionsCommand_Click(object sender, EventArgs e)
        {
            using (var optionsForm = new OptionsForm())
            {
                optionsForm.ShowDialog(this);
            }
        }

        private void SetWindow()
        {
            var windowLong = NativeMethods.GetWindowLong(this.Handle, NativeMethods.GWL.ExStyle);
            windowLong = windowLong | 0x80000 | 0x20;

            var hresult = NativeMethods.SetWindowLong(this.Handle, NativeMethods.GWL.ExStyle, windowLong);
            NativeMethods.SetLayeredWindowAttributes(this.Handle, 0, this.overlayOpacity, NativeMethods.LWA.Alpha);
        }
    }
}