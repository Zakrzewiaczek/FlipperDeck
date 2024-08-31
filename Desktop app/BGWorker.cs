using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace FlipperDeck
{
    /// <summary>
    /// Provides methods to hide and show the console window.
    /// </summary>

    public static partial class BGWorker
    {
        [LibraryImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static partial bool ShowWindow(IntPtr hWnd, int nCmdShow);


        public enum WindowState
        {
            Hide = 0,
            Show = 1,
            Minimize = 6
        }

        /// <summary>
        /// Show or hide the console window.
        /// </summary>
        public static void ChangeWindowState(IntPtr hWnd, WindowState state)
        {
            ShowWindow(hWnd, (int)state);
        }
    }
}

