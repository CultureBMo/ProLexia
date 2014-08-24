namespace ProLexia
{
    using System;

    internal static class NativeMethods
    {
        internal enum GWL
        {
            ExStyle = -20
        }

        internal enum LWA
        {
            ColorKey = 0x1,
            Alpha = 0x2
        }

        internal enum WS_EX
        {
            Transparent = 0x20,
            Layered = 0x80000
        }

        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        internal static extern int GetWindowLong(IntPtr hWnd, GWL nIndex);

        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        internal static extern bool SetLayeredWindowAttributes(IntPtr hWnd, int crKey, byte alpha, LWA dwFlags);

        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        internal static extern int SetWindowLong(IntPtr hWnd, GWL nIndex, int dwNewLong);
    }
}