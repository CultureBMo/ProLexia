namespace ProLexia
{
    using System;

    internal static class NativeMethods
    {
        internal enum GWL
        {
            ExStyle = -20,
        }

        internal enum LWA
        {
            ColorKey = 0x1,
            Alpha = 0x2,
        }

        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        internal static extern int GetWindowLong(IntPtr hWnd, GWL nIndex);

        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        internal static extern bool SetLayeredWindowAttributes(IntPtr hWnd, int crKey, int alpha, LWA dwFlags);

        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        internal static extern int SetWindowLong(IntPtr hWnd, GWL nIndex, int dwNewLong);
    }
}
