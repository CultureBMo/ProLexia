using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProLexia
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.ContextMenu contextMenu;
        private System.Windows.Forms.MenuItem exitCommand;

        public MainForm()
        {
            InitializeComponent();

            this.exitCommand = new System.Windows.Forms.MenuItem();
            this.exitCommand.Index = 0;
            this.exitCommand.Text = "E&xit";
            this.exitCommand.Click += new System.EventHandler(this.ExitCommand_Click);

            this.contextMenu = new System.Windows.Forms.ContextMenu();
            this.contextMenu.MenuItems.AddRange(new[] { this.exitCommand });

            this.notifyIcon.Icon = new Icon("Windows.ico");
            this.notifyIcon.ContextMenu = this.contextMenu;
            this.notifyIcon.Visible = true;

            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;

            int wl = GetWindowLong(this.Handle, GWL.ExStyle);
            wl = wl | 0x80000 | 0x20;
            SetWindowLong(this.Handle, GWL.ExStyle, wl);
            SetLayeredWindowAttributes(this.Handle, 0, 128, LWA.Alpha);
        }

        public enum GWL
        {
            ExStyle = -20
        }

        public enum LWA
        {
            ColorKey = 0x1,
            Alpha = 0x2
        }

        public enum WS_EX
        {
            Transparent = 0x20,
            Layered = 0x80000
        }

        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        public static extern int GetWindowLong(IntPtr hWnd, GWL nIndex);

        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        public static extern bool SetLayeredWindowAttributes(IntPtr hWnd, int crKey, byte alpha, LWA dwFlags);

        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        public static extern int SetWindowLong(IntPtr hWnd, GWL nIndex, int dwNewLong);

        private void ExitCommand_Click(object Sender, EventArgs e)
        {
            this.Close();
        }
    }
}