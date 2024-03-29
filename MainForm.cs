namespace ProLexia
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using ProLexia.Properties;

    /// <summary>
    /// Represents the main form of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly System.Windows.Forms.ContextMenuStrip contextMenu;
        private readonly System.Windows.Forms.ToolStripMenuItem exitCommand;
        private readonly System.Windows.Forms.ToolStripMenuItem optionsCommand;
        private int overlayOpacity;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();

            this.optionsCommand = new System.Windows.Forms.ToolStripMenuItem
            {
                Text = Resources.OptionsText,
            };
            this.optionsCommand.Click += new System.EventHandler(this.OptionsCommand_Click);

            this.exitCommand = new System.Windows.Forms.ToolStripMenuItem
            {
                Text = Resources.ExitText,
            };
            this.exitCommand.Click += new System.EventHandler(this.ExitCommand_Click);

            this.contextMenu = new System.Windows.Forms.ContextMenuStrip();
            this.contextMenu.Items.AddRange(new[] { this.optionsCommand, this.exitCommand });

            this.notifyIcon.Icon = new Icon("Janik-Baumgartner-Woocons-Chart-Pie.ico");
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Visible = true;

            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.BackColor = GetColorFromProperties();
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;

            this.OverlayOpacity = Properties.Settings.Default.Opacity;
        }

        /// <summary>
        /// Gets or sets the overlay opacity.
        /// </summary>
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
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            // method moved here from MainForm designer
            if (disposing)
            {
                this.optionsCommand.Dispose();
                this.exitCommand.Dispose();
                this.contextMenu.Dispose();
                this.components?.Dispose();
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Gets the color from the properties.
        /// </summary>
        /// <returns>The color.</returns>
        private static Color GetColorFromProperties()
        {
            var settings = Properties.Settings.Default;

            return Color.FromArgb(settings.OverlayRed, settings.OverlayGreen, settings.OverlayBlue);
        }

        /// <summary>
        /// Handles the Click event of the ExitCommand control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ExitCommand_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the OptionsCommand control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OptionsCommand_Click(object sender, EventArgs e)
        {
            using var optionsForm = new OptionsForm();
            optionsForm.ShowDialog(this);
        }

        /// <summary>
        /// Sets the window.
        /// </summary>
        private void SetWindow()
        {
            var windowLong = NativeMethods.GetWindowLong(this.Handle, NativeMethods.GWL.ExStyle);
            windowLong = windowLong | 0x80000 | 0x20;

            _ = NativeMethods.SetWindowLong(this.Handle, NativeMethods.GWL.ExStyle, windowLong);
            NativeMethods.SetLayeredWindowAttributes(this.Handle, 0, this.overlayOpacity, NativeMethods.LWA.Alpha);
        }
    }
}
