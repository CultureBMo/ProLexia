namespace ProLexia
{
    using System;

    /// <summary>
    /// Provides native methods for window operations.
    /// </summary>
    internal static class NativeMethods
    {
        /// <summary>
        /// Enumerates the GetWindowLong function constants.
        /// </summary>
        internal enum GWL
        {
            /// <summary>
            /// Sets a new extended window style. This value is used with the GetWindowLong and SetWindowLong functions.
            /// </summary>
            ExStyle = -20,
        }

        /// <summary>
        /// Enumerates the Layered Window Attributes flags.
        /// </summary>
        internal enum LWA
        {
            /// <summary>
            /// Use colorKey as the transparency color.
            /// </summary>
            ColorKey = 0x1,

            /// <summary>
            /// Use alpha to determine the opacity of the layered window.
            /// </summary>
            Alpha = 0x2,
        }

        /// <summary>
        /// Retrieves information about the specified window.
        /// </summary>
        /// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs.</param>
        /// <param name="nIndex">The zero-based offset to the value to be retrieved.</param>
        /// <returns>The requested value indicates success. Zero indicates failure.</returns>
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        internal static extern int GetWindowLong(IntPtr hWnd, GWL nIndex);

        /// <summary>
        /// Sets the opacity and transparency color key of a layered window.
        /// </summary>
        /// <param name="hWnd">A handle to the layered window.</param>
        /// <param name="crKey">A colorref value that specifies the transparency color key to be used when composing the layered window.</param>
        /// <param name="alpha">The alpha value to be used when composing the layered window.</param>
        /// <param name="dwFlags">Specifies the type of layered window attributes.</param>
        /// <returns>True if the function succeeds, false otherwise.</returns>
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        internal static extern bool SetLayeredWindowAttributes(IntPtr hWnd, int crKey, int alpha, LWA dwFlags);

        /// <summary>
        /// Changes an attribute of the specified window.
        /// </summary>
        /// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs.</param>
        /// <param name="nIndex">The zero-based offset to the value to be set.</param>
        /// <param name="dwNewLong">The replacement value.</param>
        /// <returns>The previous value of the specified offset indicates success. Zero indicates failure.</returns>
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        internal static extern int SetWindowLong(IntPtr hWnd, GWL nIndex, int dwNewLong);
    }
}
