using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FlipperDeck
{
    internal partial class CustomTitleBarHandler
    {
        [LibraryImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool ReleaseCapture();

        [LibraryImport("user32.dll", EntryPoint = "SendMessageW", SetLastError = true)]
        private static partial IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        // Stałe dla funkcji SendMessage
        private const uint WM_NCLBUTTONDOWN = 0xA1;
        private const nint HTCAPTION = 0x2;

        private readonly Control _control;
        private readonly Form _form;

        public CustomTitleBarHandler(Control control, Form form)
        {
            _control = control;
            _form = form;
            _control.MouseDown += TitleBarPanel_MouseDown;
        }

        private void TitleBarPanel_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                _ = SendMessage(_form.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
